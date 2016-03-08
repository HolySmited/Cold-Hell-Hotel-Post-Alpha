using UnityEngine;
using HighlightingSystem;
using System.Collections;

public class RadioController : MonoBehaviour
{
    public bool firstOn;
    public bool radioOn;

	private GameObject frankie;
	public GameObject radioToggleWaypoint;

    private AudioSource audioSource;
    private LivingMovement moveScript;
	private FireplaceController fireplaceContol;

	private LivingMovement AImovement;

	public LevelTips tipScript;

	private Highlighter highlighter;

    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
        moveScript = GameObject.FindGameObjectWithTag("Frankie").GetComponent<LivingMovement>();
		fireplaceContol = GameObject.Find("FireplaceController").GetComponent<FireplaceController>();
		AImovement = GameObject.FindGameObjectWithTag("Frankie").GetComponent<LivingMovement>();
		frankie = GameObject.FindGameObjectWithTag("Frankie");
		tipScript = GameObject.Find("LevelGUI").GetComponent<LevelTips>();
		highlighter = gameObject.GetComponent<Highlighter>();

        firstOn = true;
        radioOn = false;

		tipScript.displayTip(3);
    }

	void Update()
	{
		if (!radioOn)
		{
			AImovement.Break();
		}

		if (firstOn)
		{
			highlighter.ConstantOn();
		}
	}

    public void LureFrankie()
    {
        if (audioSource.isPlaying)
        {
			radioOn = true;
			if (radioOn)
			{
				if (firstOn)
				{
					ChangePathToFireplace();
					fireplaceContol.isActive = true;
				}
			}
        }
        else
        {
			radioOn = false;
        }
    }

    void ChangePathToFireplace()
    {
		AImovement.TransitionPath();
		LivingSight sightScript = frankie.GetComponent<LivingSight>();
		sightScript.LightReaction(radioToggleWaypoint, gameObject);
		firstOn = false;
		highlighter.ConstantOff();
		tipScript.hideTip();
    }
}