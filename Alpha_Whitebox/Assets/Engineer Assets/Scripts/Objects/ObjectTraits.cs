using UnityEngine;
using System.Collections;

public class ObjectTraits : MonoBehaviour 
{
    /*
	* Jonathon Wigley, 3/6/2016
	* Edited from Zack's ObjectBehavior script
	* Cut down on the number of traits available
	* Adjusted names of many traits
	*/

	public const int TRAITS_SIZE = 10;  //  Very Important That This is Accurrate!!!
	//  traitNames can be static as the names of the traits won't vary
	public static string[] traitNames = new string[TRAITS_SIZE] { "Small", "Medium", "Large",
		"Severable", "Sharp", "Flame", "Electric", "On", "Moveable", "Flammable Liquid" };
	[SerializeField]
	bool[] traits = new bool[TRAITS_SIZE];
	
	ObjectSettings oSettings;
	void Start() { oSettings = GetComponent<ObjectSettings>(); }
	
	void FixedUpdate()
	{
		if (oSettings.catchingFire) oSettings.timer_CatchFire -= Time.deltaTime;
		if (oSettings.soaking) oSettings.timer_Soaking -= Time.deltaTime;
	}

	// Mass/Size of Object
	public bool trait_Small 			{ get { return traits[0]; } set { traits[0] = value; } }
	public bool trait_Medium 			{ get { return traits[1]; } set { traits[1] = value; } }
	public bool trait_Large 			{ get { return traits[2]; } set { traits[2] = value; } }

	// Objects to cut and be cut
	public bool trait_Severable			{ get { return traits[3]; } set { traits[3] = value; } }
	public bool trait_Sharp 			{ get { return traits[4]; } set { traits[4] = value; } }

	// Objects that can be toggled 
	// on and off
	public bool trait_Flame				{ get { return traits[5]; } set { traits[5] = value; } }
	public bool trait_Electric 			{ get { return traits[6]; } set { traits[6] = value; } }
	public bool trait_On				{ get { return traits[7]; } set { traits[7] = value; } }

	// Determines if an object 
	// can be picked up and blasted
	public bool trait_Moveable 			{ get { return traits[8]; } set { traits[8] = value; } }

	// Creates a larger flame reaction 
	// when thrown into fire
	public bool trait_FlammableLiquid 	{ get { return traits[9]; } set { traits[9] = value; } }
}
