using UnityEngine;
using System.Collections;

public class LivingInterface : MonoBehaviour {

	LivingSight sight;
	LivingState state;
	LivingSettings settings;
	LivingMovement movement;


	// Use this for initialization
	void Start () {
		sight = GetComponent<LivingSight> ();
		state = GetComponent<LivingState> ();
		settings = GetComponent<LivingSettings> ();
		movement = GetComponent<LivingMovement> ();
	}

	void GoTo(Vector3 pos){
		movement.AddCommand (new MoveToLocation (this.gameObject, 150.0f, 60, pos));
	}

	void GoTo(Vector3 pos, int priority){
		movement.AddCommand (new MoveToLocation (this.gameObject, 150.0f, priority, pos));
	}

	float GetDistanceFrom(Vector3 pos){
		return Vector3.Distance (transform.position, pos);
	}

	bool IsWithinDistanceFrom(float dist, Vector3 pos){
		return (Vector3.Distance(transform.position,pos) <= dist);
	}

	void PathFollow(string path){
		movement.AddCommand(new Patrol(this.gameObject, 130.0f, 50, 0.0f, true, path));
	}

	void PathFollowForTime(float time, string path){
		movement.AddCommand(new Patrol(this.gameObject, 130.0f, 50, time, false, path));
	}

	void PathFollowInTime(float time, string path){
		
	}

	void PathStartCurrentOver(){
		movement.ResetPath ();
	}

	string PathGetCurrent(){
		return movement.GetPathName();
	}

	void MovementPause(){
		movement.Pause ();
	}

	void MovementPauseForTime(float time){
		movement.AddCommand (new Pause (this.gameObject, 5.0f, 98, time));
	}

	void MovementResume(){
		movement.Resume ();
	}

	void Speak(string clipName){

	}

	void SpeakRandom(string soundType){

	}

	void SpeakStop(){

	}

	void SpeakStopImmediate(){

	}


	void InteractWith(InteractableObject obj){
		movement.AddCommand (new InteractObject (this.gameObject, 60.0f, 75, obj));
	}

	bool IsInViewOfPlayer(){
		return false;
	}

	bool IsInRoom(string roomName){
		GameObject[] rooms = GameObject.FindGameObjectsWithTag ("Room");
		foreach (GameObject g in rooms) {
			Room room = g.GetComponent<Room>();
			//if(rooms.name.Equals(roomName) && room.Contains(this)){

		}
		return false;
	}

	Room GetRoom(){
		GameObject[] rooms = GameObject.FindGameObjectsWithTag ("Room");
		foreach (GameObject g in rooms) {
			Room room = g.GetComponent<Room>();
			if(room.Contains(gameObject)){
				return room;
			}
		}
		return null;
	}

	void Wander(){
		GameObject[] rooms = GameObject.FindGameObjectsWithTag ("Room");
		Room[] wanderRoom = new Room[rooms.Length];
		for(int i  = 0; i< rooms.Length; i++) {
			wanderRoom[i] = rooms[i].GetComponent<Room>();
		}
		int ind = Random.Range (0, rooms.Length - 1);
		WanderInRoom (wanderRoom [ind]);

	}

	void WanderInCurrentRoom(){
		WanderInRoom (GetRoom ());
	}

	void WanderInRoom(string roomName){

	}

	void WanderInRoom(Room room){
		int pointsNum = Random.Range (5, 10);
		for (int i =0; i< pointsNum; i++) {
			GoTo(room.GetRandomPoint(),i);
		}
	}

	void GoToRoom(string roomName){

	}

	public void Startle(){
		movement.AddCommand(new Startle(this.gameObject, 5.0f, 100, settings.startleTime));
	}

	public void Damage(int damage){
		movement.AddCommand(new Damage(this.gameObject , 5.0f, 101, settings.damageTime, damage));
	}

	public void AddFear(int i){
		state.AddFear (i);
	}

	public void Break(){
		movement.ClearQueue ();
	}
	
}
