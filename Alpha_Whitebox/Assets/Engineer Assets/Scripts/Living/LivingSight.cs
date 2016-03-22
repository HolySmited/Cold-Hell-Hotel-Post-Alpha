using UnityEngine;
using System.Collections;

//Used as the AIs eyes and ears for specific interactions
public class LivingSight : MonoBehaviour {

	LivingSettings settings;
	LivingInterface inter;

	
	void Start() {
		settings = GetComponent<LivingSettings> ();
		inter = GetComponent<LivingInterface> ();

	}
	
	void Update(){

	}

}
