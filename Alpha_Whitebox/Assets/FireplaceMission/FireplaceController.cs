using UnityEngine;
using System.Collections;

public class FireplaceController : MonoBehaviour
{
    public bool isSolved;
	public bool isActive;

	public GameObject fireplaceToggleWaypoint;
    public GameObject fireplaceLight;
	public GameObject fireplace;
    private GameObject frankie;

    private LivingMovement AImovement;
	private MasterMissionControl master;
	private FrankieInvestigateNoise noiseController;

	private float hintTimer;
	//private LevelTips tipScript;
	private bool hintDisplayed;

    void Start ()
    {
        frankie = GameObject.FindGameObjectWithTag("Frankie");
        AImovement = GameObject.FindGameObjectWithTag("Frankie").GetComponent<LivingMovement>();
		master = GameObject.FindGameObjectWithTag("GameController").GetComponent<MasterMissionControl>();
		//tipScript = GameObject.Find("LevelGUI").GetComponent<LevelTips>();
		noiseController = frankie.GetComponent<FrankieInvestigateNoise>();
        isSolved = false;
		hintDisplayed = false;

		hintTimer = 45f;
    }

	void Update()
	{
		if (isActive)
		{
			hintTimer -= Time.deltaTime;

			if (hintTimer <= 0f && !hintDisplayed)
			{
				//tipScript.displayTip(2);
				hintDisplayed = true;
			}
		}
	}


    public void CheckFrankie()
    {
		if (isActive)
		{
			if (!fireplaceLight.activeSelf)
			{
				Vector3 frankiePosition = frankie.transform.position;
				Vector3 firePosition = fireplaceLight.transform.position;

				Debug.Log ((firePosition - frankiePosition).magnitude);

				if ((firePosition - frankiePosition).magnitude <= 12f)
				{
					if (!isSolved && master.index == 0)
					{
						//Scare frankie
						isSolved = true;
						isActive = false;
						master.Increment();
						AImovement.TransitionPath();
						//tipScript.hideTip();
						noiseController.PlayTheSound();
					}
				}
				else
				{
					LivingSight sightScript = frankie.GetComponent<LivingSight>();
					sightScript.LightReaction(fireplaceToggleWaypoint, fireplace);
				}
			}
			else
			{
				AImovement.Break();
			}
		}
    }
}