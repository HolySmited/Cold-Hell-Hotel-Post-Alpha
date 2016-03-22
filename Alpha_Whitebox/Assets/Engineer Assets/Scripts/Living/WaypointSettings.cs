using UnityEngine;
using System.Collections;

//Individual settings for each waypoint. Must be added to an empty game object
public class WaypointSettings : MonoBehaviour {

	//Stop at a waypoint for this amount of time. Does not include walk time
	public float delay;
	public bool randomDelay;
	public float minRand;
	public float maxRand;

	//Rotation of the character at this point
	public float rotationSpeed;
	public float rotationAngle;

	//Determines what animation to play for the NPC. Determines whether the animation is Character Specific or not.
	public int animationPlay;
	public bool specialAnim;

	//Speed inebtween this and the next point
	public float speedToNextPoint = 1f;



}
