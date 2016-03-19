using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoomController : MonoBehaviour 
{
	List<Collider> rooms;

	void Awake()
	{
		rooms = new List<Collider>();
	}

	// Adds a room to the overall list of rooms
	public void AddRoom(Collider room)
	{
		rooms.Add(room);
	}

	// Finds the room that contains the given object and adds it to a list of that room's objects
	public void AddObjectToRoom(GameObject obj)
	{
		// Check to see which room contains this object
		// Add the object to the correct room
		foreach(Collider room in rooms)
		{
			if(room.bounds.Contains(obj.transform.position))
			{
				room.GetComponent<Room>().AddObjectToRoom(obj);
			}
		}
	}

	// Finds the room that contains the given object and returns that room
	public GameObject GetCurrentRoom(GameObject obj)
	{
		// Check to see which room contains this object
		// Add the object to the correct room
		foreach(Collider room in rooms)
		{
			if(room.bounds.Contains(obj.transform.position))
			{
				return room.gameObject;
			}
		}

		Debug.Log("Current Room not set");
		return null;
	}
}
