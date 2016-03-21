using UnityEngine;
using System.Collections;

public class OfficeController : MonoBehaviour {

	//Check if Mission is active
		//Check if Frankie is in room
			//Check if Candle is in room
				//If Candle is in room
					//Move on to Light check
				//If Candle is not in room
					//Move on to Light check
			//Check if Lights are on
				//If Lights are on
					//Do nothing
				//If Lights are off
					//If Candle is in room
						//Turn Lights on
					//Else
						//Leave

	public bool isCandleInRoom;

	public bool isToggling;
	private LivingSight sightScript;

	private BoxCollider col;
	public GameObject frankie;
	public GameObject candle;
	public GameObject lightSwitch;
	public GameObject waypoint;

	public MasterMissionControl master;
	private FrankieInvestigateNoise noiseController;
	LivingMovement AImovement;

	// Use this for initialization
	void Start () {
		isCandleInRoom = true;

		isToggling = false;

		master = GameObject.FindGameObjectWithTag("GameController").GetComponent<MasterMissionControl>();
		AImovement = GameObject.FindGameObjectWithTag("Frankie").GetComponent<LivingMovement>();
		noiseController = GameObject.FindGameObjectWithTag("Frankie").GetComponent<FrankieInvestigateNoise>();

		col = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		if (master.index == 1)
		{
			if (col.bounds.Contains(frankie.transform.position))
			{
				if (col.bounds.Contains(candle.transform.position))
				{
					isCandleInRoom = true;
				}
				else
				{
					isCandleInRoom = false;
				}

				if (!lightSwitch.GetComponent<ObjectBehavior>().trait_Powered)
				{
					if (isCandleInRoom && !isToggling)
					{
						sightScript = frankie.GetComponent<LivingSight>();
						sightScript.LightReaction(waypoint, lightSwitch);
						isToggling = true;
					}
					else if (!isCandleInRoom)
					{
						master.Increment();
						AImovement.Break ();
						AImovement.TransitionPath();
						noiseController.PlayTheSound();
					}
				}
				else
				{
					/*if (isToggling)
					{
						AImovement.Break ();
					}*/

					isToggling = false;
				}
			}
		}
	}
}
