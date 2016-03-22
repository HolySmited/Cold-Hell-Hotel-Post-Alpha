using UnityEngine;
using System.Collections;

public class Pause : Command {

	float timer;
	float counter;
	
	public Pause(GameObject obj, float memory, int priority, float time) : base(obj,memory,priority){
		timer = time;
	}
	
	public override void Initiate () {
		this.move.Pause ();
		started = true;
	}
	
	public override void Update(){
		counter += Time.deltaTime;
		if (counter >= timer) {
			ended = true;
		}
	}
	
	public override void End () {
		this.move.Resume();
		
	}

}
