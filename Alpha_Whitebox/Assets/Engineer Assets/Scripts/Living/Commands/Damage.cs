using UnityEngine;
using System.Collections;

public class Damage : Command {

	float timer;
	float counter;
	int damage;

	public Damage(GameObject obj, float memory, int priority, float time, int damage) : base(obj,memory,priority){
		timer = time;
		this.damage = damage;
	}
	
	public override void Initiate () {
		this.move.Pause ();
		started = true;
		this.anim.StartAnimation ("IsHurt");
		settings.moveState = LivingSettings.MoveState.interrupted;

	}
	
	public override void Update(){
		counter += Time.deltaTime;
		if (counter >= timer) {
			ended = true;
		}
	}

	public override void End () {
		this.anim.EndAnimation ("IsHurt");
		this.move.Resume();
		this.settings.health -= damage;
	}
}
