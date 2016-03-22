using UnityEngine;
using System.Collections;

//Used as the AIs eyes and ears for specific interactions
public class LivingSight : MonoBehaviour {

	LivingSettings settings;
	LivingInterface inter;
	PCAbilities abil;
	float fieldOfViewAngle;
	float timeSinceLastSight;
	
	void Start() {
		settings = GetComponent<LivingSettings> ();
		inter = GetComponent<LivingInterface> ();
		abil = GameObject.FindGameObjectWithTag ("Player").GetComponent<PCAbilities> ();
		fieldOfViewAngle = settings.viewAngle;

	}
	
	void Update(){

		if (null != abil.heldObj && settings.sightTimer < timeSinceLastSight) {
			CheckSight ();
		} else {
			timeSinceLastSight += Time.deltaTime;
		}
	}

	void CheckSight(){
		Vector3 direction = abil.heldObj.transform.position - transform.position;
		float angle = Vector3.Angle(direction, transform.forward);
		if(angle < fieldOfViewAngle * 0.5f){
			RaycastHit hit;
			if(Physics.Raycast(transform.position + transform.up, direction.normalized, out hit, settings.sightDist)){

				inter.Startle();
				inter.AddFear(settings.sightFear);
				timeSinceLastSight = 0.0f;

			}
		}
	}

}
