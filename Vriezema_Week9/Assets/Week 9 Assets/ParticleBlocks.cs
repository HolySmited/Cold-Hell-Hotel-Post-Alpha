using UnityEngine;
using System.Collections;

public class ParticleBlocks : MonoBehaviour {

	float lifeTime;
	float counter;
	public GameObject player;
	public Vector3 position;
	Rigidbody rigid;
	
	// Use this for initialization
	void Start () {
		lifeTime = 1.0f;
		rigid = this.GetComponent<Rigidbody> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (counter == 0.0) {
			rigid.AddForce(new Vector3(position.x - player.transform.position.x + Random.Range(-1,1), Random.Range(3,10), position.z - player.transform.position.z + Random.Range(-1,1)));
		}
		
		counter += Time.deltaTime;
		
		if (counter > lifeTime) {
			GameObject.Destroy(gameObject);
		}
	}
}
