using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Jonathon Wigley

public class VolumeReset : MonoBehaviour 
{
	public List<GameObject> objectsInVolume;
	public List<Vector3> objectTransforms;
	public List<Quaternion> objectRotations;
	public List<GameObject> objectsOutOfRoom;

	private bool startTimer;
	private float timer;
	public float timeBeforeReset;

	private GameObject player;
	private bool playerInBounds;
	private bool lastPlayerCheck;

	private bool transformsCopied;

	private Collider triggerVolume;
	private VolumeController volController;
	private VolumeReset volReset;
	private PlayerInteractor playerInteract;

	void Awake()
	{
		// Set reference to the volume trigger controller and this object's volume reset component
		volController = GameObject.FindGameObjectWithTag("GameController").GetComponent<VolumeController>();
		volReset = GetComponent<VolumeReset>();

		// Add this volume to the list of volumes in the volume trigger controller
		volController.volumes.Add(volReset);
	}

	void Start () 
	{
		// Set references to the player object and this volume's trigger volume
		player = GameObject.FindGameObjectWithTag("Player");
		playerInteract = player.GetComponent<PlayerInteractor>();
		triggerVolume = GetComponent<Collider>();
	}

	void Update () 
	{
		// Copy the transforms of the objects within this volume to the transforms list
		// Cannot do in start because of unity load orders
		if(!transformsCopied)
		{
			copyTransforms();
			transformsCopied = true;
		}

		// Check if the player is within the bounds of this trigger
		playerInBounds = triggerVolume.bounds.Contains(player.transform.position);

		/* If the player is within this collider
		- Send this volume to the trigger controller as the current player location
		- Set start timer to false so a timer won't be triggered
		- Reset the timer
		- Say that the player was in the volume in the last frame*/
		if(playerInBounds)
		{
			volController.currentVolume = volReset;
			startTimer = false;
			timer = 0;
			lastPlayerCheck = true;
		}
		// If the player was within the collider in the last frame, start the reset timer
		else if(lastPlayerCheck == true)
		{
			lastPlayerCheck = false;
			startTimer = true;
		}

		// Increment the reset timer
		if(startTimer && timer <= timeBeforeReset)
		{
			timer += Time.deltaTime;
		}

		// If the timer has reached reset, reset the position of the object and stop the timer
		if(startTimer && timer >= timeBeforeReset)
		{
			for(int i = 0; i < objectsInVolume.Count; i++)
			{
/*				if(!objectsOutOfRoom.Contains(objectsInVolume[i]))
				{*/
					/*Vector3 newpos = new Vector3(objectTransforms[i].x, objectTransforms[i].y, 
					                             objectTransforms[i].z);*/
					/*Vector3 newpos = objectTransforms[i];
					Quaternion newrot = objectRotations[i];*/
				if(objectsInVolume[i].GetComponent<ObjectBehavior>().trait_Sharp)
					continue;
				else if(playerInteract.heldObj == objectsInVolume[i])
				{
					continue;
				}


					objectsInVolume[i].transform.position = objectTransforms[i];
					objectsInVolume[i].transform.rotation = objectRotations[i];
					objectsInVolume[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
					objectsInVolume[i].GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
				//}
			}

			startTimer = false;
		}

	}

	// Copy the transforms of all the objects in the volume into the transforms list
	void copyTransforms()
	{
		foreach(GameObject obj in objectsInVolume)
		{
			//Vector3 newpos = new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z);
			Vector3 newpos = obj.transform.position;
			Quaternion newrot = obj.transform.rotation;
			objectTransforms.Add(newpos);
			objectRotations.Add(newrot);

		}
	}

/*	void OnTriggerExit(Collider other)
	{
		if(!triggerVolume.bounds.Contains(other.transform.position))
		{
			if(other.transform.parent != null && other.transform.parent.gameObject.layer != LayerMask.NameToLayer("Items_Interactable"))
			{
				objectsOutOfRoom.Add(other.gameObject);
				volController.sendOutOfBoundsObjects(this.GetComponent<VolumeReset>(), other.gameObject);
			}else
			{
				if(!objectsOutOfRoom.Contains(other.transform.parent.gameObject))
				{
					objectsOutOfRoom.Add(other.transform.parent.gameObject);
					volController.sendOutOfBoundsObjects(this.GetComponent<VolumeReset>(), other.transform.parent.gameObject);
				}
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if(mesh.bounds.Contains(other.transform.position))
		{
			if(other.transform.parent != null && other.transform.parent.gameObject.layer != LayerMask.NameToLayer("Items_Interactable"))
			{
				objectsOutOfRoom.Remove(other.gameObject);
			}else
			{
				objectsOutOfRoom.Remove(other.transform.parent.gameObject);
			}
		}
	
	}*/
}
