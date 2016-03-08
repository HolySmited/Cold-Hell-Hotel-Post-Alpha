using UnityEngine;
using System.Collections;

public class LevelTips : MonoBehaviour
{
    public static LevelTips LevelTipsRef = null;

    [SerializeField]
    GameObject tip_CheckKitchen, tip_KnifeChandelier, tip_LightsOff, tip_ScareFrankie;
    public GameObject activeTip = null;
    const int _tipID_CheckKitchen = 0, _tipID_KnifeChandelier = 1, _tipID_LightsOff = 2, _tipID_ScareFrankie = 3;
    public static int tipID_CheckKitchen = _tipID_CheckKitchen, tipID_KnifeChandelier = _tipID_KnifeChandelier, tipID_LightsOff = _tipID_LightsOff, tipID_ScareFrankie = _tipID_ScareFrankie;

    const int tipCount = 4;
    
	[SerializeField]
    float tipFrequency_CheckKitchen = 0, tipFrequency_KnifeChandelier = 0, tipFrequency_LightsOff = 0, tipFrequency_ScareFrankie = 0;
    [SerializeField]
    public float tipTimer, tipTimeDisplayed = 0, activeFrequency = 0;
    float displayPeriod = 5;

    void Awake()
    {
        if (LevelTipsRef == null)
            LevelTipsRef = this;
        else
            GameObject.Destroy(this);
    }

    void FixedUpdate()
    {
        checkTip();
        if (parseInput)
            foo();
    }
    void OnDisable()
    {
        disableTip();
    }

    void checkTip()
    {
        /*if (activeTip != null)
        {
            if ((tipTimer += Time.deltaTime) > activeFrequency)
                displayTip();
            if (activeTip.activeSelf && (tipTimeDisplayed += Time.deltaTime) > displayPeriod)
                hideTip();
        }*/
    }

    public void displayTip(int idNumber = -1)
    {
		setAble_Tip(idNumber); 
        tipTimer = 0;
		if (activeTip != null)
			activeTip.SetActive(true);
    }
    public void hideTip()
    {
        tipTimeDisplayed = 0;
        if (activeTip != null)
            activeTip.SetActive(false);
    }
    public void resetTips()
    {
        hideTip();
        activeFrequency = 0;
        tipTimer = 0;
    }
    public void disableTip()
    {
        setAble_Tip(-1);
    }
    public bool setAble_Tip(int tipID)
    {
        resetTips();
        if (tipID >= tipCount)
            return false;

        switch (tipID)
        {
            case _tipID_CheckKitchen:
                activeTip = tip_CheckKitchen;
                activeFrequency = tipFrequency_CheckKitchen;
                break;
            case _tipID_KnifeChandelier:
                activeTip = tip_KnifeChandelier;
                activeFrequency = tipFrequency_KnifeChandelier;
                break;
            case _tipID_LightsOff:
                activeTip = tip_LightsOff;
                activeFrequency = tipFrequency_LightsOff;
                break;
            case _tipID_ScareFrankie:
                activeTip = tip_ScareFrankie;
                activeFrequency = tipFrequency_ScareFrankie;
                break;
            default:
                activeTip = null;
                activeFrequency = Mathf.Infinity;
                break;
        }

        return true;
    }
    

    #region Debug Methods
    public int idInput = -1;
    public bool parseInput = false;
    void foo()
    {
        setAble_Tip(idInput);
        parseInput = false;
    }
    #endregion
}