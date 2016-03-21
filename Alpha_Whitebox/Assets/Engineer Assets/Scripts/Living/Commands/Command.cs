using UnityEngine;
using System.Collections;

public class Command{

	public int priority;
	float memory;
	protected LivingAnimation anim;
	protected LivingSettings settings;
	protected LivingMovement move;
	protected LivingState state;


	public bool started;
	public bool ended;
	public bool forgotten;

	public Command(GameObject jakie, float memory, int priority){
		this.priority = priority;
		this.memory = memory;
		started = false;
		ended = false;
		forgotten = false;

		anim = jakie.GetComponent<LivingAnimation> ();
		settings = jakie.GetComponent<LivingSettings> ();
		move = jakie.GetComponent<LivingMovement> ();
		state = jakie.GetComponent<LivingState> ();

	}

	// Use this for initialization
	public virtual void Initiate () {
		Debug.Log ("Command_Initiate");
	}

	public virtual void Update(){

	}

	// Update is called once per frame
	public virtual void End () {
		Debug.Log ("Command_End");
	}

	public virtual void Inactive(){
		memory -= Time.deltaTime;
		if (memory <= 0) {
			forgotten = true;
		}
	}
}
