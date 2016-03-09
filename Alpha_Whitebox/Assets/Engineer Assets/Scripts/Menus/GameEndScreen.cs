using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class GameEndScreen : MonoBehaviour 
{
    [SerializeField]
	GameObject endScreen;
	[SerializeField]
	Sprite congrats, gameover;
	bool endReached = false;
	void Start ()
    {
		endReached = false;
        deactivateScreens();
	}

	public void activateGameOverScreen(){ activateScreen(gameover); }
	public void activateCongratsScreen(){ activateScreen(congrats); }
	
    void activateScreen(Sprite activeImage) 
	{ 
		if (endScreen.activeSelf || endReached) return;
		endReached = true;
		toggleScreen();
		deactivateScreens();
		endScreen.SetActive(true);
		endScreen.GetComponentInChildren<Image>().sprite = activeImage;
		GetComponent<GameMenu>().closeMenu();
		GetComponent<GameMenu>().showCursor();
		PCSettings.staticRef.canControlPlayer = false;
	}
	
	public void deactivateScreens()
    {
		endScreen.SetActive(false);
    }

	void toggleScreen()
	{
		endScreen.SetActive(true);
		endScreen.SetActive(false);
	}
}
