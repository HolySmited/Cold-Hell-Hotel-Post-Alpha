using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDUI : MonoBehaviour
{
    [SerializeField]
    Texture2D reticle;
    Rect reticlePos;

    void Start()
    {

    }

    void FixedUpdate()
    {
        reticlePos = new Rect((Screen.width - reticle.width) / 2, (Screen.height - reticle.height) / 2, reticle.width, reticle.height);
    }

    void OnGUI()
    {
        if (canDraw())
            GUI.DrawTexture(reticlePos, reticle);
    }

    public bool hudEnabled = true;
    bool canDraw()
    {
        return hudEnabled && (Application.loadedLevel == LevelManager.sceneID_TestLevel || Application.loadedLevel == LevelManager.sceneID_MainLevel) && Time.timeScale != 0;
    }
}