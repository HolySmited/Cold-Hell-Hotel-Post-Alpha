using UnityEngine;
using HighlightingSystem;
using System.Collections;

public class ChandelierController : MonoBehaviour {
    public bool notActivated;
    public bool isDone;

    public GameObject clara;
    private Vector3 spawnPos;

    public GameObject knife;
    private Highlighter highlighter;

    public ObjectBehavior chandelierScript;

    private LivingMovement moveScript;

	public MasterMissionControl master;

	private LevelTips tipScript;

	private FrankieInvestigateNoise noiseController;
	private AudioSource claraSource;

    void Start()
    {
        notActivated = true;
        isDone = false;

		clara.SetActive(false);

        highlighter = knife.GetComponent<Highlighter>();
        spawnPos = new Vector3(26f, 0f, 6f);

        chandelierScript = GameObject.Find("ChandelierModel").GetComponent<ObjectBehavior>();

        moveScript = GameObject.FindWithTag("Frankie").GetComponent<LivingMovement>();

		master = GameObject.FindGameObjectWithTag("GameController").GetComponent<MasterMissionControl>();

		tipScript = GameObject.Find("LevelGUI").GetComponent<LevelTips>();

		noiseController = GameObject.FindGameObjectWithTag("Frankie").GetComponent<FrankieInvestigateNoise>();
    }

	public bool YOUWIN = false;
    void Update()
    {
        if (notActivated && master.index == 4)
        {
            highlighter.ConstantOn();
			clara.SetActive(true);

			claraSource = clara.GetComponent<AudioSource>();
			noiseController.PlayTheOtherSound(claraSource);

            notActivated = false;
        }

        if (!isDone)
        {
            if (!chandelierScript.trait_Severable && master.index == 4)
            {
				tipScript.hideTip();
				noiseController.PlayTheSound();
                moveScript.TransitionPath();
				master.Increment();
                isDone = true;
            }
        }

		if (YOUWIN)
			FindObjectOfType<GameEndScreen>().activateCongratsScreen();

    }
}
