using UnityEngine;
using System.Collections;

public class LivingSettings : MonoBehaviour {
	//Determines which character this is.
	public enum Character{Frankie,Clara,Wonathan};
	public Character charName;

	public bool dead;
	public float patrolSpeed;
	
	//paths and speed of patroling said paths
	public PatrolPath[] paths;

	//Determines the state of the AI. Includes fear states and invesitgate States
	[HideInInspector]
	public enum FearState{calm, nervous, scared, terrified, extra_calm};
	[HideInInspector]
	public enum MoveState{onPath, wander, toItem, paused, toLocation, interrupted, extra_calm, waiting};

	bool startled;
	public FearState fearState;
	public MoveState moveState;
	public MoveState prevState;

	public int stress;
	public float calmTimer;
	public int nervous;
	public int scared;
	public int terrified;
	public int decay;

	public float startleTime;
	public float damageTime;

	public int health;

	public float sightDist;
	public int sightFear;
	public float sightTimer;
	public float viewAngle;

	public AudioClip scream;
	public AudioClip heartbeat;

}
