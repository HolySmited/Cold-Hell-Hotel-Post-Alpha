using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LightMissionController : MonoBehaviour {

    public string Name;
    public List<GameObject> switchList;
	public bool lightsAreOn;
    public GameObject candle;
    LivingMovement AImovement;
	public MasterMissionControl master;

	public bool candleInRoom;

	private FrankieInvestigateNoise noiseController;

    void Start ()
    {
		// Set references
		master = GameObject.FindGameObjectWithTag("GameController").GetComponent<MasterMissionControl>();
        AImovement = GameObject.FindGameObjectWithTag("Frankie").GetComponent<LivingMovement>();
		noiseController = GameObject.FindGameObjectWithTag("Frankie").GetComponent<FrankieInvestigateNoise>();
  		
		lightsAreOn = true;
	}

    public void CheckLights()
    {
		Debug.Log ("Check Lights");
		// Initially believe that lights are on
		lightsAreOn = false;

		// For every switch in the list, check if the lights are on
        foreach (GameObject _switch in switchList)
        {
			// For every child light in the switch
            //for (int i = 0; i < _switch.transform.childCount; i++)
			//{
				// If the switch is the candle object
                if (_switch == candle)
                {
					// If the candle is in the room, set lights are on
                    if (candleInRoom)
                    {
                        lightsAreOn = true;
                        //break;
                    }
                }
				// If the switch is the light object, and it is on, set lights are on
                else if (_switch.GetComponent<ObjectBehavior>().trait_Powered)
				{
					lightsAreOn = true;
					//break;
				}
			//}
        }
		Debug.Log (lightsAreOn);
		// If the lights are off, move on to the next mission
        if (!lightsAreOn && (master.index == 1 || master.index == 2))
        {
			print ("WE HAVE REACHED THE SPOT");
            AImovement.Break();
			AImovement.TransitionPath();
			master.Increment();
			noiseController.PlayTheSound();
        }
    }




}
