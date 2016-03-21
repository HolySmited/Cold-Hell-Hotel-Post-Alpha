using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MasterMissionControl : MonoBehaviour {

    public List<GameObject> missionList = new List<GameObject>();
	public GameObject currentMission;

    private bool initialized;
    public int index;
    public LivingSight frankie;

	private float timer;

    void Start ()
    {
        frankie = GameObject.FindGameObjectWithTag("Frankie").GetComponent<LivingSight>();
		timer = 5f;
	}

	void Update ()
    {
		// Activate the first mission
	    if(!initialized)
        {
            Initialize();
        }

		if (index == 5)
		{
			timer -= Time.deltaTime;

			if (timer <= 0f)
			{
				
				//FindObjectOfType<GameEndScreen>().activateCongratsScreen();
			}
		}
	}

	// Deactivate all missions except for the first one
    void Initialize()
    {
        index = 0;
/*        foreach (GameObject mission in missionList)
        {
            mission.SetActive(false);
        }
        missionList[index].SetActive(true);*/
		currentMission = missionList[index];

		initialized = true;
    }

	//move on to the next mission
    public void Increment()
    {
		// Deactivate the current mission and set the fear level
       // missionList[index].SetActive(false);
		
        switch (index)
        {

		default:
			break;
        }

		// Increment the index and move to the next mission
		index++;
		//missionList[index].SetActive(true);
		currentMission = missionList[index];
    }
}
