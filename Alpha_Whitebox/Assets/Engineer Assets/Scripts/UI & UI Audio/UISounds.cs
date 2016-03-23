using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(AudioSource))]

public class UISounds : MonoBehaviour
{
    [SerializeField]
    AudioClip menuBackground, clickSound, scrollSound;
    static AudioSource audiosource;
    public static UISounds uiSounds = null;

    void Awake()
    {
        //  Cache Components at Awake so Sound can be Played @ Start
        if (uiSounds != null)
        {
            print("Destroying duplicate UISounds");
            Destroy(this.gameObject);
            return;
        }
        uiSounds = GetComponent<UISounds>();
        audiosource = GetComponent<AudioSource>();
        GameObject.DontDestroyOnLoad(this);
    }
    public bool startfade = false;
    void Update()
    {
        if (startfade)
        {
            startfade = false;
            uiSounds.startFadeout();
        }
    }

    #region Predefined Audio OneShots
    public void oneshot_Click()
    {
        audiosource.PlayOneShot(clickSound);
    }
    public void oneshot_Scroll()
    {
        audiosource.PlayOneShot(clickSound);
    }
    #endregion
    #region Predefined Audio Loops
    public void loopMenuBackground()
    {
        stopFading = true;

        audiosource.loop = true;
        audiosource.clip = menuBackground;
        audiosource.Play();
    }
    #endregion

    #region Audio Source Utility
    public void startFadeout(float endVolume = 1)
    {
        StartCoroutine(fadeout(endVolume));
    }

    static bool fading = false, stopFading = false;
    static IEnumerator fadeout(float endVolume)
    {
        if (fading) yield break;
        fading = true;  //  checkout fade to prevent multiple concurrent fades
        stopFading = false;

        float timer = 0, fadePeriod = 5f;
        while ((audiosource.volume = 1 - (timer += Time.unscaledDeltaTime) / fadePeriod) > 0) yield return null;

        //  If interrupted fade, continue to play audio. Else, don't.
        if (!stopFading)
            audiosource.Stop();
        stopFading = false;

        audiosource.volume = endVolume; //  reset volume to given value (default is 1, or max)

        fading = false; //  checkin fade
    }
    #endregion
}
