using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VolumeController : MonoBehaviour 
{
	public struct OOBObject
	{
		public VolumeReset vol;
		public GameObject obj;
	};

	public List<VolumeReset> volumes;
	public List<OOBObject> outObjects;

	public VolumeReset currentVolume;
	public VolumeReset lastVolume;

	public float timeBeforeReset;

	void Start()
	{
		//lastVolume = currentVolume;
		foreach(VolumeReset vol in volumes)
		{
			vol.timeBeforeReset = timeBeforeReset;
		}

	}

/*	void Update()
	{
		if(lastVolume != currentVolume)
		{
			lastVolume = currentVolume;
			foreach(OOBObject oob in outObjects)
			{
				if(oob.vol != currentVolume)
				{
					oob.vol.objectsOutOfRoom.Remove(oob.obj);
				}
			}
		}

	}*/

	public void sendTransform(Transform pos)
	{
		// Add each interactable object sent to their respective volume
		foreach(VolumeReset volume in volumes)
		{
			if(volume.GetComponent<Collider>().bounds.Contains(pos.position))
			{
				volume.objectsInVolume.Add(pos.gameObject);
			} 
		}
	}

/*	public void sendOutOfBoundsObjects(VolumeReset vol, GameObject outObj)
	{
		OOBObject obj;
		obj.vol = vol;
		obj.obj = outObj;

		outObjects.Add(obj);
	}*/
}
