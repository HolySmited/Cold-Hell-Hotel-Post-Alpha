using UnityEngine;
using System.Collections;

public class Startle : Command {

	float timer;
	float counter;

	public Startle(GameObject obj, float memory, int priority, float time) : base(obj,memory,priority){
		timer = time;
	}
	
	public override void Initiate () {
		this.move.Pause ();
		started = true;
		this.anim.StartAnimation ("Startled");
		
	}
	
	public override void Update(){
		counter += Time.deltaTime;
		if (counter >= timer) {
			ended = true;
		}
	}
	
	public override void End () {

		this.move.Resume();
		this.anim.EndAnimation ("Startled");
	}
}
