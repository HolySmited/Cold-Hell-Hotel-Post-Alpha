/*using UnityEngine;
using System.Collections;

public class CandleScript : SwitchBase 
{
    //public GameObject waypoint;
    void Start()
    {
        frankie = GameObject.FindGameObjectWithTag("Frankie").GetComponent<LivingSight>();
        //_object = GetComponent<InteractableObject>();
    }

    public override void SwitchToggled()
    {
        //Transform[] tempArray = gameObject.GetComponentsInChildren<Transform>();
       // foreach (Transform light in tempArray)
       // {
       //     if (!light.gameObject.activeInHierarchy)
        //    {
               //frankie.LightReaction(waypoint, gameObject);
        //    }
       // }
        //frankie.LightReaction(waypoint, gameObject);
        controller.GetComponent<LightMissionController>().CheckLights();

    }
}
*/