using UnityEngine;
using System.Collections;

public class InteractObject : Command {

	InteractableObject obj;
	Vector3 target;
	float animTimer;
	float counter;

	public InteractObject(GameObject obj, float memory, int priority, InteractableObject inter) : base(obj,memory,priority){
		this.obj = inter;
		this.target = inter.gameObject.transform.position;
	}

	public override void Initiate () {
		move.ToLocation (target);
		started = true;
	}
	
	public override void Update(){
		if (move.nav.remainingDistance < move.nav.stoppingDistance) {
			if(counter > animTimer){
				anim.EndAnimation("InvestigatingMid");
				ended = true;
			}else{
				anim.StartAnimation("InvestigatingMid");
			}
			counter += Time.deltaTime;
		}
	}
	
	public override void End () {
		obj.specialInteract (null);
	}
}
