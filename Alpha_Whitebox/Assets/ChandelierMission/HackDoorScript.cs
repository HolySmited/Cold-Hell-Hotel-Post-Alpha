using UnityEngine;
using System.Collections;

public class HackDoorScript : MonoBehaviour {

	public float timer;
	public GameObject door;

	private ChandelierController chandelierControl;

	public float speed = 3f;

	private LevelTips tipScript;

	private bool isDone;
	private bool doorOpen;
	private float hintTimer;

	// Use this for initialization
	void Start () {
		timer = 13f;
		chandelierControl = GameObject.Find("ChandelierController").GetComponent<ChandelierController>();
		tipScript = GameObject.Find("LevelGUI").GetComponent<LevelTips>();
		isDone = false;
		doorOpen = false;
		hintTimer = 90f;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isDone)
		{
			if (!chandelierControl.notActivated)
			{
				timer -= Time.deltaTime;
				
				if (timer <= 0f)
				{
					gameObject.GetComponent<MeshRenderer>().enabled = false;
					gameObject.GetComponent<BoxCollider>().enabled = false;
					doorOpen = true;
				}

				if (doorOpen)
				{
					hintTimer -= Time.deltaTime;
				}

				if (hintTimer <= 0f)
				{
					tipScript.displayTip(1);
					isDone = true;
				}
			}
		}
	}
}