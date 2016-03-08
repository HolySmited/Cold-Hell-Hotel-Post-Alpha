using UnityEngine;
using System.Collections;

public class CandleZoneScript : MonoBehaviour 
{
	public GameObject candle;

	private bool candleInRoomControl;

	private LightMissionController controller;
    private BoxCollider col;

	void Start()
	{
		controller = transform.parent.GetComponentInChildren<LightMissionController>();
        col = GetComponent<BoxCollider>();

		candleInRoomControl = true;
	}
    void Update()
    {
        if(!(col.bounds.Contains(candle.transform.position)))
        {
            controller.candleInRoom = false;
        }
		else
		{
			controller.candleInRoom = true;
			candleInRoomControl = true;
		}

		if (candleInRoomControl)
		{
			if (!controller.candleInRoom)
			{
				Debug.Log ("Candle check");
				controller.CheckLights();
				candleInRoomControl = false;
			}
		}

        
    }
}
