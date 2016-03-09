using UnityEngine;
using System.Collections;

//manages the AI's fear while in different states
public class LivingState : MonoBehaviour {

	//Variable for reducing fear state should the player take too long
	private float timeSinceLastFear;

	//Referances to components found in the Character object
	private LivingSight sight;
	private LivingMovement movement;
	private LivingSettings settings;
	private LivingAnimation anim;



	// Use this for initialization
	void Start () {
		settings = this.GetComponent<LivingSettings> ();
		sight = this.GetComponent<LivingSight>();
		movement = this.GetComponent<LivingMovement> ();
		anim = this.GetComponent<LivingAnimation> ();

		timeSinceLastFear = 0.0f;
	}

	// Manages the AI's fear while in different states
	void Update () {
		CheckHealth ();
		if (settings.patrol) {
			Patrol ();
		}
	}

	//Called when the AI is startled. Pauses the current patrol, plays startle animations
	public void Startle(){
		ResetPatrol ();
		settings.patrol = false;
		settings.fearState = LivingSettings.FearState.startled;
		anim.StartGenericAnim (1);
		movement.SetCurrentWaitTime (settings.curiousTimer);
	}

	//Called when the AI spots an interaction. Puts him in an investigative state
	public void Reaction(Vector3 i){
		ResetPatrol ();
		settings.patrol = false;
		movement.SetNavDestination(i);
		movement.SetCurrentWaitTime (settings.curiousTimer);
	}

	public void Reaction(Vector3 i, float waitTime){
		ResetPatrol ();
		settings.patrol = false;
		movement.SetNavDestination(i);
		movement.SetCurrentWaitTime (waitTime);
	}

	//Reduces the AI's fear overtime as they continue to patrol
	void Patrol(){
	}

	//Resets the AI's calm timer after a scare of some sort
	void ResetPatrol(){
		timeSinceLastFear = 0;
		settings.calmValue = 1;
	}

	void CheckHealth(){
		if (settings.health <= 0) {
			this.Murder();
			settings.fearState = LivingSettings.FearState.extra_calm;
			settings.patrol = false;
		}
	}

	void Murder(){
		movement.PausePatrol();
	}
		
}
