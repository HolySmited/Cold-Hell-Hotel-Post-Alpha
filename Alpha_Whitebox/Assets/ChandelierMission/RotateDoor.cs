using UnityEngine;
using System.Collections;

public class RotateDoor : MonoBehaviour 
{
	public float speed;
	
	// Update is called once per frame
	public void AlterDoor()
    {
        Debug.Log("Entered door");
        if (transform.rotation.y >= Mathf.PI / 2)
            StartCoroutine("OpenDoor");
        else
            StopAllCoroutines();
    }

    IEnumerator OpenDoor()
    {
        transform.RotateAround(transform.localPosition, Vector3.up, speed * Time.deltaTime);
        Debug.Log("Entered coroutine");
        yield return null;
    }
}
