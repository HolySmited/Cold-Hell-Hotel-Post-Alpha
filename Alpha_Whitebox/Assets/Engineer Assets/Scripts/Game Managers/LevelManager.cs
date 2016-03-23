using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class LevelManager : MonoBehaviour
{
    #region Attributes
    public const int sceneID_GameStart = 0, sceneID_LoadingScreen = 1, sceneID_TitleScreen = 2, sceneID_TestLevel = 3, sceneID_MainLevel = 5;

    public static LevelManager levelManager;
    #endregion

    void Awake()
    {
        if (levelManager != null)
        {
            GameObject.Destroy(this.gameObject);
            return;
        }
        levelManager = this;
        GameObject.DontDestroyOnLoad(this);
    }

    #region Utilities
    public static void reload()
    {
        Debug.Log("Reloading Current Level");
        Application.LoadLevel(Application.loadedLevel);
    }
    public static void restart()
    {
        Debug.Log("Restarting Game");
        Application.LoadLevel(sceneID_TitleScreen);
    }
    public static void exit()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }
    #endregion

    #region Scene Loading Methods
    public void loadTitle()
    {
        StartCoroutine(loadLevel(sceneID_TitleScreen));
    }
    public void loadLevel_Test()
    {
        StartCoroutine(loadLevel(sceneID_TestLevel, true));
    }
    public void loadLevel_Main()
    {
        StartCoroutine(loadLevel(sceneID_MainLevel, true));
    }
    #endregion

    //  Primary Level Loader
    int asyncLevelLoadCount = 0;
    public IEnumerator loadLevel(int levelID, bool useLS = false)
    {
        Application.LoadLevel(sceneID_LoadingScreen);    //  Load empty scene

        //  Activate Loading Screen
        if (useLS)
        {
            GetComponent<LoadingScreenUI>().open_Fade();
            yield return new WaitForSeconds(1);
        }

        Debug.Log("Loading Level ID: " + levelID);
        asyncLevelLoadCount++;
        if (asyncLevelLoadCount > 1)
            Debug.Log("WARNING: Consecutive Async Scene Loadings!");

        //  Variables to track level loading progress (progress history preserves the last two progress checks).
        decimal progressAverage = 0;
        Queue<decimal> progressHistory = new Queue<decimal>();
        progressHistory.Enqueue(0);
        progressHistory.Enqueue(0);
        int progressTrackCount = progressHistory.Count;

        yield return null;
        AsyncOperation async = Application.LoadLevelAsync(levelID);

        async.allowSceneActivation = false;

        while (!async.isDone)
        {
            //  Get the Load Progress %
            decimal progress = (decimal)async.progress;

            //  If the progress is equal to the average, then chances are the scene is nearly finished loading so it is okay to switch to it.
            async.allowSceneActivation = progress == progressAverage;
            progressHistory.Enqueue(progress);
            progressAverage += ((progress - progressHistory.Dequeue()) / progressTrackCount);
            yield return null;
        }
        asyncLevelLoadCount--;
        
        //  Close Loading Screen
        if (useLS)
        {
            GetComponent<LoadingScreenUI>().close_Fade();
            yield return new WaitForSeconds(1);
        }
    }
}
