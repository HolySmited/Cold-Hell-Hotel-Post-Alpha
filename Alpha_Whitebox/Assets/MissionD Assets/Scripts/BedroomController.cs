using UnityEngine;
using System.Collections;

public class BedroomController : MonoBehaviour {

	//Check if Mission is active
		//Check if Frankie is in room
			//Check if Bedroom Light is on
				//Flip bool
			//Check if Bathroom Light is on
				//Flip bool
			//Check if both bools are false
				//Leave
			//If Bedroom is on and Bathroom is not
				//Flip Bathroom
			//If Bedroom is off and Bathroom is on
				//Flip Bedroom				

	public bool isFrankie;
	public bool isMission;

	public bool isBedroomOn;
	public bool isBathroomOn;
	
	public bool isToggling;
	private LivingSight sightScript;
	
	private BoxCollider col;
	public GameObject frankie;
	public GameObject bedroomSwitch;
	public GameObject bathroomSwitch;
	public GameObject bedroomWaypoint;
	public GameObject bathroomWaypoint;
	
	public MasterMissionControl master;
	private FrankieInvestigateNoise noiseController;
	LivingMovement AImovement;
	
	// Use this for initialization
	void Start () {
		isBathroomOn = true;
		isBedroomOn = true;
		
		isToggling = false;
		
		master = GameObject.FindGameObjectWithTag("GameController").GetComponent<MasterMissionControl>();
		AImovement = GameObject.FindGameObjectWithTag("Frankie").GetComponent<LivingMovement>();
		noiseController = GameObject.FindGameObjectWithTag("Frankie").GetComponent<FrankieInvestigateNoise>();
		
		col = GetComponent<BoxCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		if (master.index == 2)
		{
			isMission = true;
			if (col.bounds.Contains(frankie.transform.position))
			{
				isFrankie = true;
				if (!bedroomSwitch.GetComponent<ObjectBehavior>().trait_Powered)
				{
					isBedroomOn = false;
				}
				else if (bedroomSwitch.GetComponent<ObjectBehavior>().trait_Powered)
				{
					isBedroomOn = true;
				}

				if (!bathroomSwitch.GetComponent<ObjectBehavior>().trait_Powered)
				{
					isBathroomOn = false;
				}
				else if (bathroomSwitch.GetComponent<ObjectBehavior>().trait_Powered)
				{
					isBathroomOn = true;
				}
				
				if (!isBedroomOn && !isBathroomOn)
				{
					AImovement.Break ();
					master.Increment();
					AImovement.TransitionPath();
					noiseController.PlayTheSound();
				}
				else if (!isBedroomOn && isBathroomOn)
				{
					sightScript = frankie.GetComponent<LivingSight>();
					sightScript.LightReaction(bedroomWaypoint, bedroomSwitch);
					isToggling = true;
				}
				else if (isBedroomOn && !isBathroomOn)
				{
					sightScript = frankie.GetComponent<LivingSight>();
					sightScript.LightReaction(bathroomWaypoint, bathroomSwitch);
					isToggling = true;
				}
			}
			else
			{
				isFrankie = false;
			}
		}
		else
		{
			isMission = false;
		}
	}
}
