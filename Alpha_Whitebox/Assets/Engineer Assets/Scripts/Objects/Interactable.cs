using UnityEngine;
using System.Collections;
using HighlightingSystem;

[RequireComponent(typeof(ObjectTraits))]
[RequireComponent(typeof(ObjectSettings))]
[RequireComponent(typeof(Highlighter))]
[RequireComponent(typeof(AudioSource))]

public class Interactable : MonoBehaviour, IInteractableObject 
{
	/* Jonathon Wigley, 3/11/16*/

	ObjectTraits traits;
	AudioSource audioSource;
	Highlighter highlight;
	Rigidbody rBody;
	Camera playerCamera;

	RoomController roomController;
	public GameObject currentRoom;// {get; set;}

	// Names of audio clips and traits
	public const int Small=0, Medium=1, Large=2, Severable=3, Sharp=4, Flame=5, Electric=6, On=7, Movable=8, FlammableLiquid=9;
	public const int SoundCollision=0, SoundBlast=1, SoundInteract=2, SoundOn=3, SoundOff=4;

	// All the different types of sounds an object can have
	public AudioClip collisionSound;
	public AudioClip blastSound;
	public AudioClip interactSound;
	public AudioClip onSound;
	public AudioClip offSound;

	// Gets set to true when this object is interacted with, then resets to false
	bool interactedPlayer, interactedNPC;
	public bool IsInteractedWithByPlayer{get{return interactedPlayer;} set{interactedPlayer = value;}}
	public bool IsInteractedWithByNPC{get{return interactedNPC;} set{interactedNPC = value;}}

	// Used to check if the object is being held by the player or NPC
	bool heldPlayer, heldNPC;
	public bool IsHeldByPlayer{get{return heldPlayer;} set{heldPlayer = value;}}
	public bool IsHeldByNPC{get{return heldNPC;} set{heldNPC = value;}}

	// Different highlight variable
	bool highlightPermanent;
	bool highlightPermanentColor;
	Color permColor;

	// Starting position variables
	Vector3 startPosition;
	Quaternion startRotation;

	// Timer utility variables
	double timeCount = 0;
	double timeStart, timeEnd;

	// Booleans to tell which function is running
	bool highForTime,
	highColorForTime,
	highAfterTime,
	highColorAfterTime,
	highAfterTimeForTime,
	highColorAfterTimeForTime,
	beenHigh;
	float showTime;

	void Start () 
	{
		traits = GetComponent<ObjectTraits>();
		audioSource = GetComponent<AudioSource>();
		highlight = GetComponent<Highlighter>();
		highlight.SeeThroughOff();
		rBody = GetComponent<Rigidbody>();
		playerCamera = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Camera>();

		startPosition = transform.position;
		startRotation = transform.rotation;

		roomController = GameObject.FindGameObjectWithTag("GameController").GetComponent<RoomController>();
		currentRoom = roomController.GetCurrentRoom(this.gameObject);
		currentRoom.GetComponent<Room>().AddObjectToRoomAtStart(this.gameObject);

		if(IsType(Flame) || IsType(Electric))
		{
			if(IsType(On))
				TurnOn(true);
			else
				TurnOn(false);
		}
	}

	void Update () 
	{
		// Timing
		timeCount += Time.deltaTime;

		if(highlightPermanent)
			highlight.ConstantOnImmediate();
		if(highlightPermanentColor)
			highlight.ConstantOnImmediate(permColor);

		// Room Updating
		if(currentRoom == null)
		{
			if(roomController.GetCurrentRoom(this.gameObject) != null)
			{
				currentRoom = roomController.GetCurrentRoom(this.gameObject);
				currentRoom.GetComponent<Room>().objectJustEntered = true;
				currentRoom.GetComponent<Room>().mostRecentEnter = this.gameObject;
			}
		}

		// Reset interacted to false right after it has been interacted with
		if(interactedPlayer)
			interactedPlayer = false;
		if(interactedNPC)
			interactedNPC = false;

		// Highlighting
		if(highForTime)
		{
			if(timeCount > timeEnd)
				HighlightForTime(1);
		}else if(highColorForTime)
		{
			if(timeCount > timeEnd)
				HighlightColorForTime(1, Color.yellow);
		}else if(highAfterTime)
		{
			if(timeCount > timeEnd)
				HighlightAfterTime(1);
		}else if(highColorAfterTime)
		{
			if(timeCount > timeEnd)
				HighlightColorAfterTime(1, Color.yellow);
		}else if(highAfterTimeForTime)
		{
			if(timeCount > timeEnd)
				HighlightAfterTimeForTime(1, 1);
		}else if(highColorAfterTimeForTime)
		{
			if(timeCount > timeEnd)
				HighlightColorAfterTimeForTime(1, 1, Color.yellow);
		}
	}

	// Turn on the object, e.g. light the flame flip the switch
	public void TurnOn(bool onOff)
	{
		// If this object can be toggled, turn it on
		if(traits.trait_Flame || traits.trait_Electric)
		{
			traits.trait_On = onOff;

			// Enable or Disable all the light components in the object's children
			foreach(Light light in GetComponentsInChildren<Light>())
			{
				light.enabled = traits.trait_On;
			}

			if(traits.trait_Flame)
				transform.FindChild("Flame").gameObject.SetActive(traits.trait_On);

		}else
		{
			Debug.Log("You tried to TURN ON or TURN OFF something that doesn't have an on/off state.");
		}
	}
	
	// Toggle the object power state, e.g. put out a lit flame or turn on an off switch
	public void Toggle()
	{
		// If this object can be toggled, toggle it
		if(traits.trait_Flame || traits.trait_Electric)
		{
			traits.trait_On = !traits.trait_On;

			// Enable or Disable all the light components in the object's children
			foreach(Light light in GetComponentsInChildren<Light>())
			{
				light.enabled = traits.trait_On;
			}

			if(traits.trait_Flame)
				transform.FindChild("Flame").gameObject.SetActive(traits.trait_On);

		}else
		{
			Debug.Log("You tried to TOGGLE something that doesn't have an on/off state.");
		}
	}
	
	// Return true if the object is on
	public bool isOn()
	{
		return traits.trait_On;
	}
	
	// Return true if the object has the given trait/type
	public bool IsType(int type)
	{
		switch(type)
		{
		case Electric: return traits.trait_Electric; break;
		case Flame: return traits.trait_Flame; break;
		case FlammableLiquid: return traits.trait_FlammableLiquid; break;
		case Small: return traits.trait_Small; break;
		case Medium: return traits.trait_Medium; break;
		case Large: return traits.trait_Large; break;
		case Movable: return traits.trait_Moveable; break;
		case On: return traits.trait_On; break;
		case Sharp: return traits.trait_Sharp; break;
		case Severable: return traits.trait_Severable; break;
		default: return false; break;
		}
	}
	
	// Play the given audio clip once
	public void SoundPlayOnce(int soundName)
	{
		switch(soundName)
		{
		case SoundCollision: audioSource.PlayOneShot(collisionSound); break;
		case SoundBlast: audioSource.PlayOneShot(blastSound); break;
		case SoundInteract: audioSource.PlayOneShot(interactSound); break;
		case SoundOn: audioSource.PlayOneShot(onSound); break;
		case SoundOff: audioSource.PlayOneShot(offSound); break;
		}
	}
	
	// Loop the given audio clip for the given amount of time
	public void SoundPlayForTime(float time, int soundName)
	{

	}

	// Stop playing given sound after its current cycle has completed
	public void SoundStop(int soundName)
	{

	}
	
	// Stop playing the given sound immediately
	public void SoundStopImmediate(int soundName)
	{

	}
	
	// Stop playing all sounds after they have finished their current cycle
	public void SoundStopAll()
	{

	}
	
	// Stop playing all sounds immediately
	public void SoundStopAllImmediate()
	{
		audioSource.Stop();
	}
	
	// Pause the given sound until SoundResume is called
	public void SoundPause(int soundName)
	{

	}
	
	// Pause the given sound for the given amount of time, then resume
	public void SoundPauseForTime(float time, int soundName)
	{

	}
	
	// Pause all sounds until they are resumed by SoundResumeAll
	public void SoundPauseAll()
	{
		audioSource.Pause();
	}
	
	// Pause all sounds for the given amount of time, then resume
	public void SoundPauseAllForTime(float time)
	{

	}
	
	// Resume playing the given sound
	public void SoundResume(int soundName)
	{

	}
	
	// Resume all sounds
	public void SoundResumeAll()
	{
		audioSource.UnPause();
	}
	
	// Permanently highlight the default color for this object
	public void HighlightPermanent()
	{
		highlightPermanent = true;
	}
	
	// Permanently highlight the given color
	public void HighlightPermanentColor(Color color)
	{
		highlightPermanentColor = true;
		permColor = color;
	}
	
	// Highlight default color for the given time
	public void HighlightForTime(float time)
	{
		if(!highForTime)
		{
			timeStart = timeCount;
			timeEnd = timeCount + time;
			highForTime = true;
		}else
			highForTime = false;

		if(timeCount < timeEnd)
		{
			HighlightPermanent();
		}else
		{
			HighlightOff();
		}
	}
	
	// Highlight given color for the given amount of time
	public void HighlightColorForTime(float time, Color color)
	{
		if(!highColorForTime)
		{
			timeStart = timeCount;
			timeEnd = timeCount + time;
			highColorForTime = true;
		}else
			highColorForTime = false;
		
		if(timeCount < timeEnd)
		{
			HighlightPermanentColor(color);
		}else
		{
			HighlightOff();
		}
	}
	
	// Highlight the default color after the given amount of time
	public void HighlightAfterTime(float time)
	{
		if(!highAfterTime)
		{
			timeStart = timeCount;
			timeEnd = timeCount + time;
			highAfterTime = true;
		}else
			highAfterTime = false;
		
		if(timeCount > timeEnd)
		{
			HighlightPermanent();
		}else
		{
			HighlightOff();
		}
	}
	
	// Highlight the given color after the given amount of time
	public void HighlightColorAfterTime(float time, Color color)
	{
		if(!highColorAfterTime)
		{
			timeStart = timeCount;
			timeEnd = timeCount + time;
			highColorAfterTime = true;
			permColor = color;
		}else
			highColorAfterTime = false;
		
		if(timeCount > timeEnd)
		{
			HighlightPermanentColor(permColor);
		}
	}
	
	// Highlight the default color after the given time "timeWait", for the given time "timeShow"
	public void HighlightAfterTimeForTime(float timeWait, float timeShow)
	{
		if(!highAfterTimeForTime)
		{
			timeStart = timeCount;
			timeEnd = timeCount + timeWait;
			highAfterTimeForTime = true;
			showTime = timeShow;
		}else if(!beenHigh)
		{
			timeEnd += showTime;
			beenHigh = true;
		}else
		{
			highAfterTimeForTime = false;
			beenHigh = false;
		}
		
		if(beenHigh)
		{
			HighlightPermanent();
		}else if(!highAfterTimeForTime && !beenHigh)
		{
			HighlightOff();
		}
	}
	
	// Highlight the given color after the given time "timeWait", for the given time "timeShow"
	public void HighlightColorAfterTimeForTime(float timeWait, float timeShow, Color color)
	{
		if(!highColorAfterTimeForTime)
		{
			timeStart = timeCount;
			timeEnd = timeCount + timeWait;
			highColorAfterTimeForTime = true;
			showTime = timeShow;
			permColor = color;
		}else if(!beenHigh)
		{
			timeEnd += showTime;
			beenHigh = true;
		}else
		{
			highColorAfterTimeForTime = false;
			beenHigh = false;
		}
		
		if(beenHigh)
		{
			HighlightPermanentColor(permColor);
		}else if(!highColorAfterTimeForTime && !beenHigh)
		{
			HighlightOff();
		}
	}
	
	// Turn the highlighter off
	public void HighlightOff()
	{
		highlight.Off();
		highlightPermanent = false;
		highlightPermanentColor = false;
	}

	// Enable or disable an object's highlighter based on enabler
	public void HighlightEnable(bool enabler)
	{
		highlight.enabled = enabler;
	}
	
	// Check if it is within the given distance from the given position
	public bool IsWithinDistanceFrom(float dist, GameObject obj)
	{
		return Vector3.Distance(obj.transform.position, transform.position) < dist;
	}
	 
	// Return the distance the object is from the given position
	public float GetDistanceFrom(GameObject obj)
	{
		return Vector3.Distance(obj.transform.position, transform.position);
	}
	
	// Resets the object to the position it was at the start of the game
	public void ResetPosition()
	{
		// Only reset position if this object is moveable and has a Rigidbody
		if(rBody != null)
		{	
			transform.position = startPosition;
			transform.rotation = startRotation;
			rBody.angularVelocity = Vector3.zero;
			rBody.velocity = Vector3.zero;}
		}
	
	// Returns true if the object is in the player's field of view
	public bool IsInViewOfPlayer()
	{
		return GetComponent<Renderer>().isVisible;
	}
}
