using UnityEngine;
using System.Collections;

public abstract class SwitchBase : MonoBehaviour
{
    public LivingSight frankie;
    public InteractableObject _object;

    public Transform[] tempArray;
    public GameObject controller;

    public abstract void SwitchToggled();

}
