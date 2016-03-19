using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using HighlightingSystem;

public class Room : MonoBehaviour , IRoom
{
	 /*
	 * Jonathon Wigley, 3/9/16
	 */

	RoomController controller;

	Collider col; // The rooms trigger collider

	// Stores the most recent object to enter/exit
	public GameObject mostRecentExit;
	public GameObject mostRecentEnter; 

	// Marked true if an object entered in the last frame
	// Will then be marked false in the next frame
	public bool objectJustEntered{get; set;}
	public bool objectJustExited{get; set;} 

	public List<GameObject> objectsInRoomAtStart; // Stores a list of all objects that were in the room at the start of the game
	public List<GameObject> objectsInRoom;	// Stores a list of all objects currently in the room
	bool objectCheck;	// Whether or not all the objects in the room have been checked

	List<Light> lightsInRoom;
	bool lightCheck;

	void Awake()
	{
		// Add this room to the list of rooms in RoomController
		controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<RoomController>();
		col = GetComponent<Collider>();
		controller.AddRoom(col);
	}

	void Start()
	{
		objectsInRoomAtStart = new List<GameObject>();
		objectsInRoom = objectsInRoomAtStart;
		lightsInRoom = new List<Light>();
	}

	void Update () 
	{
		if(objectJustEntered)
			objectJustEntered = false;
		if(objectJustExited)
			objectJustExited = false;
	}

	// Returns true if the given position is within the room
	public bool Contains(GameObject obj)
	{
		if(col.bounds.Contains(obj.transform.position))
			return true;
		else
			return false;
	}
	
	// Returns true when the given object has just left the room
	// Should be put in a class' Update()
	public bool ObjectExits(GameObject obj)
	{
		if(objectJustExited && mostRecentExit.Equals(obj))
			return true;
		else
			return false;
	}
	
	// Returns true when the object has just entered the room
	// Should be put in a class' Update()
	public bool ObjectEnters(GameObject obj)
	{
		if(objectJustEntered && mostRecentEnter.Equals(obj))
			return true;
		else
			return false;
	}

	// Returns any interactable object that has just left the room
	public GameObject GetLastObjectExited()
	{
		return mostRecentExit;
	}
	
	// Returns any interactable object that has just entered the room
	public GameObject GetLastObjectEntered()
	{
		return mostRecentEnter;
	}
	
	// Resets all objects that were originally in the room to their original position
	public void ResetObjectPositions()
	{
		foreach(GameObject obj in objectsInRoomAtStart)
		{
			obj.GetComponent<Interactable>().ResetPosition();
		}
	}
	
	// Returns a float based on the number of lights turned on in the room
	public float GetLightLevel()
	{
		// Total number of light sources in the room
		int lightsOn = 0, lightsOff = 0;

		// Get the number of lights in the room
		foreach(GameObject obj in objectsInRoom)
		{
			foreach(Light light in obj.GetComponentsInChildren<Light>())
			{
				if(light.enabled)
					lightsOn++;
				else
					lightsOff++;
			}
		}

		// Return the percentage of lights in the room turned on
		return lightsOn / (lightsOn + lightsOff);
	}

	// Triggers whenever an object stop touching the collider
	void OnTriggerExit(Collider other)
	{
		// Make sure the object is an interactable object
		if(other.gameObject.layer == LayerMask.NameToLayer("Items_Interactable"))
		{
			 /* 
			 * If the object was not in the room before and is in the room now,
			 * the object has entered the room
			 *
			 * NOTE: This takes care of managing the room the object left as well
			 */
			if(!objectsInRoom.Contains(other.gameObject) && 
			   controller.GetCurrentRoom(other.gameObject) == this.gameObject)
			{
				// Reference to the room the object just left
				Room otherRoom = other.gameObject.GetComponent<Interactable>().currentRoom.GetComponent<Room>();

				// Remove the object from the room it left
				otherRoom.RemoveObjectFromRoom(other.gameObject);

				// Tell the other room that this object has just left
				otherRoom.objectJustExited = true;
				otherRoom.mostRecentExit = other.gameObject;

				// Set the object's current room as this room
				other.gameObject.GetComponent<Interactable>().currentRoom = 
					controller.GetCurrentRoom(other.gameObject);

				// Add the object to this room
				AddObjectToRoom(other.gameObject);

				// Tell this room an object just entered
				objectJustEntered = true;
				mostRecentEnter = other.gameObject;
			}
			else if(!objectsInRoom.Contains(other.gameObject) && 
			        controller.GetCurrentRoom(other.gameObject) == null)
			{

				// Reference to the room the object just left
				Room otherRoom = other.gameObject.GetComponent<Interactable>().currentRoom.GetComponent<Room>();

				// Remove the object from the room it left
				otherRoom.RemoveObjectFromRoom(other.gameObject);
				
				// Tell the other room that this object has just left
				otherRoom.objectJustExited = true;
				otherRoom.mostRecentExit = other.gameObject;
				
				// Set the object's current room as null
				other.gameObject.GetComponent<Interactable>().currentRoom = null;
				
				// Tell this room an object just entered
				objectJustEntered = true;
				mostRecentEnter = other.gameObject;
			}
		}
	}

	// Adds an object to the list of objects currently in the room
	public void AddObjectToRoom(GameObject obj)
	{
		objectsInRoom.Add(obj);
	}

	// Adds an object to the list of objects in the room at the start
	public void AddObjectToRoomAtStart(GameObject obj)
	{
		objectsInRoomAtStart.Add(obj);
	}

	// Removes an object to the list of objects currently in the room
	public void RemoveObjectFromRoom(GameObject obj)
	{
		objectsInRoom.Remove(obj);
	}
}
