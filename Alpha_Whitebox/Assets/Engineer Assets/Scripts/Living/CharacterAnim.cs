using UnityEngine;
using System.Collections;

//Parent class for character animations. Will contain generic animations found in all characters
public class CharacterAnim {


	//Overridable methods for starting and ending character specific animations
	public void StartAnim(Animator anim, int select){}
	public void EndAnim(Animator anim, int select){}

	//Methods for starting and ending generic animations
	public void StartGenericAnim(Animator anim, int select){
		switch (select) {
			case 1:
				anim.SetBool("Startled",true);
				break;
			case 2:
				anim.SetBool("Collapse",true);
				break;
			case 3:
				anim.SetBool("InvestigatingMid",true);
				break;
			case 4:
				anim.SetBool("InvestigateTop",true);
				break;
			case 5:
				anim.SetBool("InvestigatingFloor",true);
				break;
		}
	}
	
	public void EndGenericAnim(Animator anim, int select){
		switch (select) {
			case 1:
				anim.SetBool("Startled",false);
				break;
			case 2:
				anim.SetBool("Collapse",false);
				break;
			case 3:
				anim.SetBool("InvestigatingMid",false);
				break;
			case 4:
				anim.SetBool("InvestigateTop",false);
				break;
			case 5:
				anim.SetBool("InvestigatingFloor",false);
				break;
		}
	}

	public void TriggerGenericAnim(Animator anim, int select){

	}
}
