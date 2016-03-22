using UnityEngine;
using System.Collections;

public class FeedBack : MonoBehaviour {

	public GameObject particle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDigHit(RaycastHit hitInfo){
		int num = Random.Range (5, 10);
		for (int i =0; i< num; i++) {
			GameObject j = GameObject.Instantiate(particle);
			j.transform.position = hitInfo.point;
		}
	}

	void OnDigMiss(RaycastHit hitInfo){
		
	}
}
