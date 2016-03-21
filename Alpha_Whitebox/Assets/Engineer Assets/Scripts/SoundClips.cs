using UnityEngine;
using System.Collections;

public class SoundClips : MonoBehaviour 
{
	AudioSource source;
	public AudioClip[] clips = new AudioClip[5];

	void Start () 
	{
		source = GetComponent<AudioSource>();
	}

	void Update () 
	{
		
	}
}
