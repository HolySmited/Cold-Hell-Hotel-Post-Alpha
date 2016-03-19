using UnityEngine;
using System.Collections;

public class FrankieInvestigateNoise : MonoBehaviour {

	private AudioSource frankieSource;
	public AudioClip[] audioClips;
	public int currentClip;

	// Use this for initialization
	void Start () {
		currentClip = 0;
		frankieSource = gameObject.GetComponent<AudioSource>();
	}
	
	public void PlayTheSound()
	{
		frankieSource.PlayOneShot(audioClips[currentClip]);

		if ((currentClip + 1) < audioClips.Length)
		{
			currentClip++;
		}
	}

	public void PlayTheSound(int soundID)
	{
		if (soundID < audioClips.Length && soundID >= 0)
		{
			frankieSource.PlayOneShot(audioClips[soundID]);
		}
	}

	public void PlayTheOtherSound(AudioSource claraSource)
	{
		claraSource.PlayOneShot(claraSource.clip);
	}
}