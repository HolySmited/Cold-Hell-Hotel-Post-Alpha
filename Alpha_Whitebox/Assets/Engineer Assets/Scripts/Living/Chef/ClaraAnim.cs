using UnityEngine;
using System.Collections;

public class ClaraAnim : CharacterAnim {
	
	/*Special Anims for Frankie
	 * 
	 * 1 - Wash Table
	 * 2 - Count Cash
	 * 3 - Read Magazine
	 * 4 - Peruse Guestbook
	 */
	
	//Will be called to run animation. Speed must be <0 to see animation
	new public void StartAnim(Animator anim, int select){
		switch (select) {
		case 1:
			anim.SetBool("IsWashingTable",true);
			break;
		case 2:
			anim.SetBool("CashCount",true);
			break;
		case 3:
			anim.SetBool("ReadMagazine",true);
			break;
		case 4:
			anim.SetBool("GuestBook",true);
			break;
		default:
			break;
		}
	}
	
	//Will be called to end the animation. 
	new public void EndAnim(Animator anim, int select){
		switch (select) {
		case 1:
			anim.SetBool("IsWashingTable",false);
			break;
		case 2:
			anim.SetBool("CashCount",false);
			break;
		case 3:
			anim.SetBool("ReadMagazine",false);
			break;
		case 4:
			anim.SetBool("GuestBook",false);
			break;
		default:
			break;
		}
		
	}
}
