using UnityEngine;
using System.Collections;

public class Patrol : Command {

	float timer;
	float counter;
	bool onTimer;
	string path;

	public Patrol(GameObject obj, float memory, int priority, float time, bool indefinite, string name) : base(obj,memory,priority){
		timer = time;
		path = name;
		onTimer = indefinite;
	}
	
	public override void Initiate () {
		settings.moveState = LivingSettings.MoveState.onPath;
		started = true;
		move.TransitionPath(path);
		
	}
	
	public override void Update(){
		counter += Time.deltaTime;
		if (counter >= timer && onTimer) {
			ended = true;
		}
	}
	
	public override void End () {
		settings.moveState = LivingSettings.MoveState.waiting;
	}
}
