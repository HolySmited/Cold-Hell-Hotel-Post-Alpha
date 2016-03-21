using UnityEngine;
using System.Collections;

public class MoveToLocation : Command {

	Vector3 target;
	
	public MoveToLocation(GameObject obj, float memory, int priority, Vector3 target) : base(obj,memory,priority){
		this.target = target;
	}

	public override void Initiate () {
		move.ToLocation (target);
		started = true;
	}
	
	public override void Update(){
		if (move.nav.remainingDistance < move.nav.stoppingDistance) {
			ended = true;
		}
	}
	
	public override void End () {
		
	}
}
