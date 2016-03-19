using UnityEngine;
using System.Collections;

public class LightningFlash : MonoBehaviour 
{
	[SerializeField]
	float timeInterval = 10, randomRange = 5, timer = 0;
	[SerializeField]
	AudioClip lightning;
	AudioSource playerAudio;

	float randomTime;
	bool resetTimer = true;

	void Start()
	{
		playerAudio = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<AudioSource>();
	}

	void Update () 
	{
		// Increment the timer
		timer += Time.deltaTime;

		// If we should reset the timer, set a new random time
		if(resetTimer)
		{
			timer = 0;
			randomTime = timeInterval + Random.Range(-randomRange, randomRange);
			resetTimer = false;
		}

		// If the timer has reached the random timer, play the sound
		if(timer > randomTime)
		{
			playerAudio.PlayOneShot(lightning);
			Debug.Log("BOOOOOM");
			resetTimer = true;
		}
	}
}
