using UnityEngine;
using System.Collections;

public class LightScript : SwitchBase 
{
    public GameObject waypoint;

    void Start()
    {
        frankie = GameObject.FindGameObjectWithTag("Frankie").GetComponent<LivingSight>();
        //_object = GetComponent<InteractableObject>();
    }
    void Update()
    { }

    public override void SwitchToggled()
    {
        Debug.Log("Switch Toggled");

        frankie.LightReaction(waypoint, gameObject);

        controller.GetComponent<LightMissionController>().CheckLights();

    }

}
