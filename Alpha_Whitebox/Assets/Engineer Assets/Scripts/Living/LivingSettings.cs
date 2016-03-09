using UnityEngine;
using System.Collections;

public class LivingSettings : MonoBehaviour {
	//Determines which character this is.
	public enum Character{Frankie,Clara};
	public Character name;

	//time spent investigating things
	public float curiousTimer = 5;
	public bool dead;

	//Radius for specific senses
	public float absoluteRadius = .5f;
	public float hearingRadius = 5f;

	//Determines if the AI should be patrolling.
	[HideInInspector]
	public bool patrol = true;

	//paths and speed of patroling said paths
	public PatrolPath[] paths;
	public float patrolSpeed = 2f;
	public float terrifiedSpeed = 6f;

	//interact state variables
	public bool interact;
	public GameObject interactee;
	public WaypointSettings interactPoint;

	//Determines the fears of the AI, their current fear level, and how much a scare increases it
	public string[] phobia;
	public int fear;
	public int fearMult;

	//time spent patroling to lose fear, and how much it decreases
	public float calmTimer;
	public int calmValue;

	//Determines the state of the AI. Includes fear states and invesitgate States
	public enum FearState{calm, nervous, scared, terrified, startled, extra_calm};
	public FearState fearState;

	public int health;

	//intializes a bunch of the above stuff to default values
	void Start(){
		fearState = LivingSettings.FearState.calm;
		fearMult = 0;
		fear = 0;
		calmValue = 1;
		calmTimer = 5f;
		curiousTimer = 6f;
		health = 5;
		dead = false;
	}

	//Method for the NPC to check his fear level, and switch states accordingly.
	public void CheckFear(){
		if (fear < 20)
			fearState = FearState.calm;
		else if(fear >= 20 && fear < 40)
			fearState = FearState.nervous;
		else if (fear >= 40 && fear < 60)
			fearState = FearState.scared;
		else
			fearState = FearState.terrified;
	}


}
