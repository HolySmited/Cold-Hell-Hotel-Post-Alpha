using UnityEngine;
using System.Collections;

//Controls the movement of the AI
public class LivingMovement : MonoBehaviour {

	LivingSettings settings;
	[HideInInspector]
	public NavMeshAgent nav;


	int pointIndex;
	PatrolPath pathFollow;
	float delayTime;

	ArrayList commands;
	Command currAction;


    void Start() {
		settings = GetComponent<LivingSettings> ();
		nav = GetComponent<NavMeshAgent> ();
		commands = new ArrayList ();
		settings.moveState = LivingSettings.MoveState.waiting;

    }

    void Update() {
		if (settings.fearState == LivingSettings.FearState.extra_calm)
			return;
		UpdateCommand ();
		Act ();
    }

	void UpdateCommand(){
		if (currAction != null) {
			if(currAction.started && !currAction.ended){
				currAction.Update();
				Debug.Log(currAction.ended);
			}else if(currAction.ended){
				currAction.End ();
				currAction = PopCommand();
			}else{
				currAction.Initiate();
				currAction.started = true;
			}
		}
	}

	void Act(){
		switch (settings.moveState) {
			case LivingSettings.MoveState.onPath:
				Patrolling();
				break;
				
			case LivingSettings.MoveState.toLocation:
				ToLocation();
				break;
				
			case LivingSettings.MoveState.toItem:
				ToItem();
				break;
				
			case LivingSettings.MoveState.interrupted:
				
				break;
				
			case LivingSettings.MoveState.paused:
				
				break;
				
			case LivingSettings.MoveState.wander:
				
				break;
				
			}
	}

    //AIs current method for patrolling a specific area
    void Patrolling() {
		if (nav.remainingDistance < nav.stoppingDistance) {
			pointIndex ++;
			if(pointIndex == pathFollow.patrolPoints.Length){
				if(pathFollow.transistionOnEnd){
					currAction.ended = true;
					pointIndex = 0;
				}
			}
			nav.SetDestination(pathFollow.patrolPoints[pointIndex].transform.position);
		}

		if (commands.Count != 0) {
			currAction.ended = true;
		}

    }


	public void TransitionPath(string name){
		settings.moveState = LivingSettings.MoveState.onPath;
		foreach(PatrolPath p in settings.paths){
			if(p.name.Equals(name)){
				pathFollow = p;
				pointIndex = 0;
				nav.SetDestination(pathFollow.patrolPoints[pointIndex].transform.position);
			}
		}
	}

	public void TransitionPath(){ 
	
	}

	public void ToLocation(Vector3 pos){
		settings.moveState = LivingSettings.MoveState.toLocation;
		NavMeshPath path = new NavMeshPath();
		if (NavMesh.CalculatePath (transform.position, pos, NavMesh.AllAreas,path))
			nav.destination = pos;
		else {
			NavMeshHit hit;
			if(nav.FindClosestEdge(out hit)){
				nav.destination = hit.position;
			}else{
				settings.moveState = LivingSettings.MoveState.waiting;
				print ("No Path Avalible");
			}
		}
	}

	public void ResetPath(){
		if (settings.moveState == LivingSettings.MoveState.onPath)
			pointIndex = 0;
	}

	public string GetPathName(){
		if (settings.moveState == LivingSettings.MoveState.onPath)
			return pathFollow.name;
		return "";
	}

	public void Pause(){
		settings.prevState = settings.moveState;
		settings.moveState = LivingSettings.MoveState.paused;
		nav.speed = 0.0f;
	}

	public void Resume(){
		settings.moveState = settings.prevState;
		settings.prevState = LivingSettings.MoveState.paused;
		nav.speed = settings.patrolSpeed;
		if (currAction is Pause) {
			currAction.ended = true;
		}
	}

	public void ToLocation(){
		if (nav.remainingDistance < nav.stoppingDistance) {
			settings.moveState = LivingSettings.MoveState.waiting;
		}
	}

	public void ToItem(){
		if (nav.remainingDistance < nav.stoppingDistance) {
			settings.moveState = LivingSettings.MoveState.waiting;
		}
	}

	public void Sort ()
	{
		int i, j;
		int N = commands.Count;
		
		for (j=N-1; j>0; j--) {
			for (i=0; i<j; i++) {
				if (((Command)commands [i]).priority > ((Command)commands [i + 1]).priority)
					Swap (commands, i, i + 1);
			}
		}
	}

	void Swap (ArrayList list, int m, int n)
	{
		Command temporary;
		
		temporary = (Command)list [m];
		list [m] = list [n];
		list [n] = temporary;
	}

	public void AddCommand(Command comm){
		if (currAction == null) {
			currAction = comm;
			return;
		}
		Command temp;
		if (currAction.priority < comm.priority) {
			temp = currAction;
			currAction = comm;
		} else {
			temp = comm;
		}
		commands.Add (temp);
		Sort ();
	}
	Command PopCommand(){
		Command temp;
		if (commands.Count >= 1) {
			temp = (Command)commands [0];
			commands.Remove (temp);
			return temp;
		} else {
			return null;
		}
	}

	public void ClearQueue(){
		commands.Clear ();
	}



}
