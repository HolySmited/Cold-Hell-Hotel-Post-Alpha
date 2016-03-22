using UnityEngine;
using System.Collections;

public class LivingAnimation : MonoBehaviour {

	LivingSettings settings;
	LivingInterface inter;
	Animator anim;
	NavMeshAgent nav;
	
	
	void Start() {
		settings = GetComponent<LivingSettings> ();
		inter = GetComponent<LivingInterface> ();
		anim = GetComponent<Animator> ();
		nav = GetComponent<NavMeshAgent> ();
		nav.updateRotation = false;
	}
	
	void Update(){
		anim.SetFloat ("Speed", nav.velocity.magnitude);
		transform.rotation = anim.rootRotation;
	}

	public void StartAnimation(string s){
		anim.SetBool (s, true);
	}

	public void EndAnimation(string s){
		anim.SetBool (s, false);
	}
}
