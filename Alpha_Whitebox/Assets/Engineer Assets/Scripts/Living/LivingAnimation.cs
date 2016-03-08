using UnityEngine;
using System.Collections;

public class LivingAnimation : MonoBehaviour {

	//components from the class for determining animation stuff to do
	private LivingSettings settings;
	private LivingMovement movement;
	private LivingState state;
	private Animator anim;
	private NavMeshAgent nav;
	private CharacterAnim animManager;

	// Use this for initialization
	void Start () {
		settings = this.GetComponent<LivingSettings> ();
		movement = this.GetComponent<LivingMovement> ();
		state = this.GetComponent<LivingState> ();
		anim = this.GetComponent<Animator> ();
		nav = this.GetComponent<NavMeshAgent> ();
		SetAnimManager ();

	}
	
	//Upfdates the animation controller with the current speed of the animation controller
	void Update () {
		anim.SetFloat ("Speed", nav.velocity.magnitude);
		CheckFearState ();
	}

	public void PauseAnim(){
		Debug.Log ("change speed");
		anim.enabled = false;
	}

	//switchings animation mental state based upon fear state
	void CheckFearState(){
		if (settings.fear < 20)
			anim.SetFloat ("MentalState", 0.0f);
		else if(settings.fear >= 20 && settings.fear < 40)
			anim.SetFloat ("MentalState",0.5f);
		else if (settings.fear >= 40 && settings.fear < 60)
			anim.SetFloat ("MentalState", 1.0f);
		else
			anim.SetBool ("IsTerrified", true);
	}
	
	//-------------------------METHODS FOR STARTING AND ENDING ANIMATIONS-------------------
	//Generic animations
	public void StartGenericAnim(int i){
		animManager.StartGenericAnim (anim, i);
	}
	public void EndGenericAnim(int i){
		animManager.EndGenericAnim (anim, i);
	}
	public void TriggerGenericAnim(int i){
		animManager.TriggerGenericAnim (anim, i);
	}

	//Waypoint Animations
	public void StartWaypointAnim(int i){
		animManager.StartAnim(anim, i);
	}
	public void EndWaypointAnim(int i){
		animManager.EndAnim(anim, i);
	}

	//Sets the animation manager based upon the current character setting
	public void SetAnimManager(){
		switch (settings.name) {
			case LivingSettings.Character.Frankie:
				animManager = new FrankieAnim ();
				break;
			case LivingSettings.Character.Clara:
				animManager = new ClaraAnim ();
				break;
			
		}
	}
	
}
