using UnityEngine;
using System.Collections;

public class MoveObject : Command {

	Vector3 target;
	InteractableObject inter;

	public MoveObject(GameObject obj, float memory, int priority, InteractableObject inter, Vector3 target) : base(obj,memory,priority){
		this.inter = inter;
		this.target = target;
	}

	public override void Initiate () {
		
	}
	
	public override void Update(){
		
	}
	
	public override void End () {
		
	}
}
