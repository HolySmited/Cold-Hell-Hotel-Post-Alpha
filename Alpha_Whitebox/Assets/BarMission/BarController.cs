using UnityEngine;
using System.Collections;

public class BarController : MonoBehaviour
{
    public GameObject[] barLightSwitches;
    public GameObject[] barLights;
    public bool isSolved;

    public const float MAX_INTENSITY = 2.5f;
    public const float MIN_INTENSITY = 0.0f;

    private static Light lightComponent = null;

    private LivingMovement moveScript;
    private ChandelierController chandelierController;
	private ResetController resetScript;
	public MasterMissionControl master;
	private FrankieInvestigateNoise noiseController;

    void Start ()
    {
        moveScript = GameObject.FindGameObjectWithTag("Frankie").GetComponent<LivingMovement>();
        chandelierController = GameObject.Find("ChandelierController").GetComponent<ChandelierController>();
		master = GameObject.FindGameObjectWithTag("GameController").GetComponent<MasterMissionControl>();
		resetScript = GameObject.Find("ResetSwitch").GetComponent<ResetController>();
		noiseController = GameObject.FindGameObjectWithTag("Frankie").GetComponent<FrankieInvestigateNoise>();

        isSolved = false;
    }

    void Update()
    {
        int disabledLights = 0;

        foreach (GameObject light in barLights)
        {
            Light lightComponent = light.GetComponent<Light>();

            if (lightComponent.intensity == MIN_INTENSITY)
            {
                disabledLights++;
            }
        }

        if (!isSolved)
        {
            if (disabledLights == 4 && master.index == 3)
            {
                isSolved = true;
                moveScript.TransitionPath();
				master.Increment();
				noiseController.PlayTheSound();
            }
            else if (disabledLights == 4 && master.index != 3)
            {
                disabledLights = 0;
				resetScript.ResetBarLights();
            }
        }
    }

    public void ToggleLights(GameObject objectClicked)
    {
        int arrayPosition = 0;

        for (int i = 0; i < barLightSwitches.Length; i++)
        {
            if (barLightSwitches[i] == objectClicked)
            {
                arrayPosition = i;
                break;
            }
        }

        lightComponent = barLights[arrayPosition].GetComponent<Light>();
        flipIntensity(lightComponent);

        if (arrayPosition > 0 && arrayPosition < barLights.Length - 1)
        {
            lightComponent = barLights[arrayPosition - 1].GetComponent<Light>();
            flipIntensity(lightComponent);

            lightComponent = barLights[arrayPosition + 1].GetComponent<Light>();
            flipIntensity(lightComponent);
        }
        else if (arrayPosition == 0)
        {
            lightComponent = barLights[arrayPosition + 1].GetComponent<Light>();
            flipIntensity(lightComponent);
        }
        else if (arrayPosition == 3)
        {
            lightComponent = barLights[arrayPosition - 1].GetComponent<Light>();
            flipIntensity(lightComponent);
        }
    }

    static void flipIntensity(Light currentLight)
    {
        if (currentLight.intensity == MAX_INTENSITY)
        {
            currentLight.intensity = MIN_INTENSITY;
        }
        else
        {
            currentLight.intensity = MAX_INTENSITY;
        }
    }
}