using UnityEngine;
using System.Collections;

public class LevelGUIManager : MonoBehaviour {
    
	void Start ()
    {
        DeactivateAll();
    }

    public void DeactivateAll()
    {
        GetComponent<GameMenu>().deactivateAllMenus();
        GetComponent<GameEndScreen>().deactivateScreens();
        //GetComponent<LevelTips>().resetTips();
    }
}
