using UnityEngine;
using System.Collections;

//Used as the AIs eyes and ears for specific interactions
public class LivingSight : MonoBehaviour {

	//Takes the last interaction from an alarm class. Checks if it can be seen
	public Vector3 lastInteraction;
	public Vector3 lastSeenInteraction;

	//Checks the priority of the interaction based upon distance and sense used to see interaction
	private int lastPriority;

	//Counts the time between this in the previous interaction
	public float timeBetweenInteraction;

	//Checks the noise threshold of the interaction to see if it should care at all
	public float noiseThreshold;

	//referances to other components of the game object
	private LivingSettings settings;
	private LivingState state;
	private LivingAnimation anim;
	private BoxCollider col;

	//Gets references of objects
	void Start(){
		settings = this.GetComponent<LivingSettings> ();
		state = this.GetComponent<LivingState> ();
		anim = this.GetComponent<LivingAnimation> ();
	}

	//temporary check to see if it is startled
	void Update () {
	}

	//TEMPORARY METHOD FOR TESTING*************
	void Startle(){
	}

	//checks sense to see if an interaction occured within it's senses range. Sends it to the state machine if true
	void CheckSenses(Interaction i){
		if (CheckAbsolute(i) || CheckHearing (i) || CheckSight(i)) {
			lastSeenInteraction = lastInteraction;
			state.Reaction(i.location);
		}
	}

	//Checks the absolute awarness bubble
	bool CheckAbsolute(Interaction i){
		if (Vector3.Distance (transform.position, i.location) < this.settings.absoluteRadius) {
			return true;
		}
		return false;
	}

	//Checks the area infront of the NPC
	bool CheckSight(Interaction i){
		if (Vector3.Dot (this.transform.position, i.location) > 0) {
			RaycastHit hit;
			Vector3 heading = this.transform.position - i.location;
			float distance = heading.magnitude;
			Vector3 direction = heading/distance;
			if(!Physics.Raycast(this.transform.position, direction, out hit, distance)){
				return true;
			}
		}
		return false;
	}

	//Checks teh area that the NPC can hear, and if it is above the noise threshold
	bool CheckHearing(Interaction i){
		if (Vector3.Distance (transform.position, i.location) < this.settings.hearingRadius) {
			RaycastHit hit;
			Vector3 heading = this.transform.position - i.location;
			float distance = heading.magnitude;
			Vector3 direction = heading/distance;
			if(!Physics.Raycast(this.transform.position, direction, out hit, distance)){
				return true;
			}
		}
		return false;
	}

	public bool RecieveInteraction(Vector3 loc, float investTime){
		if (settings.patrol) {
			state.Reaction(loc,investTime);
			return true;
		}
		return false;
	}

	public bool RecieveInteraction(Vector3 loc){
		if (settings.patrol) {
			state.Reaction(loc);
			return true;
		}
		return false;
	}

	public bool ReceiveDamage(){
		return true;
	}

	public void Murder(){
		settings.dead = true;
		settings.health = 0;
		anim.StartGenericAnim (2);
		settings.patrol = false;
		print ("MurderDaThing");
		settings.fearState = LivingSettings.FearState.extra_calm;
	}

	public void UpgradeFear(){
		settings.fear += 20;
	}

	public void LightReaction(GameObject wayPoint, GameObject light){
		Debug.Log ("Light Reaction");
		settings.interact = true;
		settings.interactee = light;
		settings.interactPoint = wayPoint.GetComponent<WaypointSettings> ();
		state.Reaction (wayPoint.transform.position, settings.interactPoint.delay);
	}

}
