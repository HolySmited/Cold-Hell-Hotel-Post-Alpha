using UnityEngine;
using System.Collections;

public class ResetController : MonoBehaviour
{

    public const float MAX_INTENSITY = 2.5f;
    public const float MIN_INTENSITY = 0.0f;

    private BarController barController;

    void Start()
    {
        barController = GameObject.Find("BarController").GetComponent<BarController>();
    }

    public void ResetBarLights()
    {
        for (int i = 0; i < 4; i++)
        {
            Light lightComponent = barController.barLights[i].GetComponent<Light>();
            if (i == 0 || i == 2)
            {
                lightComponent.intensity = MAX_INTENSITY;
            }
            else
            {
                lightComponent.intensity = MIN_INTENSITY;
            }
        }
    }
}
