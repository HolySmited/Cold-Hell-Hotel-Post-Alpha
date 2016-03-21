using UnityEngine;
using System.Collections;


//The Path class for patroling NPCs.
public class PatrolPath : MonoBehaviour {

	//Name of the path for specific switching
	public string name;

	//List of Waypoints for the NPC to move around.
	public Transform[] patrolPoints;

	//Determines if the AI will auto transition to the next path or not.
	public bool transistionOnEnd;
	public bool randomPoints;	
}
