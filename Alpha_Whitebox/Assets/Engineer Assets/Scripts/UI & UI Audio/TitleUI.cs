using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;
using System.Collections;

public class TitleUI : MonoBehaviour
{
    #region Attributes
    [SerializeField]
    Sprite titleScreen_Title, titleScreen_Narrative, titleScreen_ControlInfo;
    Sprite activeImage;

    [SerializeField]
    Image uiScreen;
    [SerializeField]
    Button buttonStartGame, buttonExitGame, buttonNext, buttonBack;

    UISounds uiSounds;

    public const int titleScreenID_Close = -1, titleScreenID_Title = 0, titleScreenID_Narrative = 1, titleScreenID_ControlInfo = 2;

    int currentScreenID = -1;
    #endregion
    
    #region In-Game Debugging
    [SerializeField]
    int debugScreenID = -1;
    [SerializeField]
    bool debugShowScreen, debugHideScreen;
    void debugUpdate()
    {
        if (debugShowScreen)
        {
            setActive(debugScreenID);
            debugShowScreen = false;
        }
        else if (debugHideScreen)
        {
            setActive(titleScreenID_Close);
            debugHideScreen = false;
        }
    }
    #endregion
    
    void FixedUpdate()
    {
        debugUpdate();
    }
    void Update()
    {
        updateTextField();
    }
    void Start()
    {
        uiSounds = UISounds.uiSounds;
        open();

        UIManager.unpause();
        UIManager.unlockCursor();

        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(0).gameObject.SetActive(true);
    }

    #region Hidden String Parser
    string inputString = "";
    float inputTimer = 0;
    void updateTextField()
    {
        if (Input.GetKey(KeyCode.Backspace))
        {
            if (inputString.Length > 0 && (Time.time - inputTimer > 0.1f || Input.GetKeyDown(KeyCode.Backspace)))
            {
                inputString = inputString.Remove(inputString.Length - 1);
                inputTimer = Time.time;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
            inputString = "";
        else
            try
            {
                if (Input.GetKeyDown(KeyCode.Return))
                    parseInputString();
                else if ((Time.time - inputTimer > 0.5f || Input.anyKeyDown) && Input.inputString[0] > 32 && inputString.Length <= 32)
                {
                    inputString += Input.inputString;
                    inputTimer = Time.time;
                }
            }
            catch { }   //  Don't need to do anything when catching here
    }
    void parseInputString()
    {
        if (getBits(inputString.ToLower()) == "1101010110100111001111100111110110011001011110011")
        {
            FindObjectOfType<LevelManager>().loadLevel_Test();
            uiSounds.startFadeout();
        }
        inputString = "";
    }
    public string getBits(string input)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in Encoding.ASCII.GetBytes(input))
            sb.Append(Convert.ToString(b, 2));
        return sb.ToString();
    }

    void OnGUI()
    {
        if (inputString.Length > 0)
            GUI.Label(new Rect(Screen.width / 8, Screen.height / 8, 400, 50), "> " + inputString);
    }
    #endregion

    #region Display Methods
    public void close() { setActive(titleScreenID_Close); inputString = ""; }
    public void open() { setActive(titleScreenID_Title); }
    #endregion

    #region Buttons
    public void Button_Next()
    {
        uiSounds.oneshot_Click();
        switch (currentScreenID)
        {
            case titleScreenID_Title:
                setActive(titleScreenID_Narrative);
                break;
            case titleScreenID_Narrative:
                setActive(titleScreenID_ControlInfo);
                break;
            case titleScreenID_ControlInfo:
                setActive(titleScreenID_Close);
                LevelManager.levelManager.loadLevel_Main();
                break;
            default:
                setActive(titleScreenID_Close);
                Debug.Log("Error - TitleUI: Button_Next Invalid ID " + currentScreenID);
                break;
        }
    }
    public void Button_Back()
    {
        uiSounds.oneshot_Click();
        switch (currentScreenID)
        {
            case titleScreenID_Title:
                setActive(titleScreenID_Close);
                LevelManager.exit();
                break;
            case titleScreenID_Narrative:
                setActive(titleScreenID_Title);
                break;
            case titleScreenID_ControlInfo:
                setActive(titleScreenID_Narrative);
                break;
            default:
                setActive(titleScreenID_Close);
                Debug.Log("Error - TitleUI: Button_Back Invalid ID " + currentScreenID);
                break;
        }
    }
    #endregion    
    #region Utilities
    void setActive(int titlescreenID, bool immediateDisplay = true)
    {
        //  Switch the Active to the Given Index
        switch (titlescreenID)
        {
            case titleScreenID_Title:
                activeImage = titleScreen_Title;
                currentScreenID = titleScreenID_Title;
                enableTitleButtons();
                uiSounds.loopMenuBackground();
                break;
            case titleScreenID_Narrative:
                activeImage = titleScreen_Narrative;
                currentScreenID = titleScreenID_Narrative;
                enableIntroButtons();
                break;
            case titleScreenID_ControlInfo:
                activeImage = titleScreen_ControlInfo;
                currentScreenID = titleScreenID_ControlInfo;
                enableIntroButtons();
                break;
            default:
                //  Disable the Screen
                activeImage = null;
                currentScreenID = titleScreenID_Close;
                hideScreen();
                uiSounds.startFadeout();
                return;
        }
        //  Immediate Display Option
        if (immediateDisplay)
            showScreen();
        else
            hideScreen();
    }
    public void showScreen()
    {
        uiScreen.sprite = activeImage;
        uiScreen.gameObject.SetActive(true);
    }
    public void hideScreen()
    {
        uiScreen.gameObject.SetActive(false);
        disableButtons();
    }
    void enableTitleButtons()
    {
        disableButtons();
        buttonStartGame.gameObject.SetActive(true);
        buttonExitGame.gameObject.SetActive(true);
    }
    void enableIntroButtons()
    {
        disableButtons();
        buttonNext.gameObject.SetActive(true);
        //buttonBack.gameObject.SetActive(true);
    }
    void disableButtons()
    {
        buttonStartGame.gameObject.SetActive(false);
        buttonExitGame.gameObject.SetActive(false);
        buttonNext.gameObject.SetActive(false);
        buttonBack.gameObject.SetActive(false);
    }
    #endregion
}
