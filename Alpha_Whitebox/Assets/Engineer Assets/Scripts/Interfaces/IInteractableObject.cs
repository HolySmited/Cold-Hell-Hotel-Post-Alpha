using UnityEngine;
using System.Collections;

public interface IInteractableObject
{
	/*// Turn on the object, e.g. light the flame flip the switch
	void TurnOn();

	// Turn off the object, e.g. put out the flame, turn off the switch
	void TurnOff();

	// Toggle the object power state, e.g. put out a lit flame or turn on an off switch
	void Toggle();

	// Return true if the object is on
	bool isOn();

	// Return true if the object has just been interacted with by the player
	bool IsInteractedWithByPlayer();

	// Returns true if the object has just been interacted with by an NPC
	bool IsInteractedWithByNPC();

	// Return true if the object has the given trait/type
	bool IsType(string type);

	// Play the given audio clip once
	void SoundPlayOnce(string soundName);

	// Loop the given audio clip for the given amount of time
	void SoundPlayForTime(float time, string soundName);

	// Stop playing given sound after its current cycle has completed
	void SoundStop(string soundName);

	// Stop playing the given sound immediately
	void SoundStopImmediate(string soundName);

	// Stop playing all sounds after they have finished their current cycle
	void SoundStopAll();

	// Stop playing all sounds immediately
	void SoundStopAllImmediate();

	// Pause the given sound until SoundResume is called
	void SoundPause(string soundName);

	// Pause the given sound for the given amount of time, then resume
	void SoundPauseForTime(float time, string soundName);

	// Pause all sounds until they are resumed by SoundResumeAll
	void SoundPauseAll();

	// Pause all sounds for the given amount of time, then resume
	void SoundPauseAllForTime(float time);

	// Resume playing the given sound
	void SoundResume(string soundName);
	
	// Resume all sounds
	void SoundResumeAll();

	// Permanently highlight the default color for this object
	void HighlightPermanent();

	// Permanently highlight the given color
	void HighlightPermanentColor(Color color);

	// Highlight default color for the given time
	void HighlightForTime(float time);

	// Highlight given color for the given amount of time
	void HighlightColorForTime(float time, Color color);

	// Highlight the default color after the given amount of time
	void HighlightAfterTime();

	// Highlight the given color after the given amount of time
	void HighlightColorAfterTime();

	// Highlight the default color after the given time "timeWait", for the given time "timeShow"
	void HighlightAfterTimeForTime();

	// Highlight the given color after the given time "timeWait", for the given time "timeShow"
	void HighLightColorAfterTimeForTime(float timeWait, float timeShow, Color color);

	// Turn the highlighter off
	void HighlightOff();

	// Disable the highlighter until HighlightReenable is called
	void HighLightPermanentDisable();

	// Enable a disabled highlighter
	void HighlightEnable();

	// Check if it is within the given distance from the given position
	bool IsWithinDistanceFrom(float dist, Vector3 pos);

	// Return the distance the object is from the given position
	float GetDistanceFrom(Vector3 pos);

	// Resets the object to the position it was at the start of the game
	void ResetPosition();

	// Returns true if the object is in the player's field of view
	bool IsInViewOfPlayer();

	// Returns true if this is the currently held object
	bool IsHeldByPlayer();

	// Returns true if this is currently held by and NPC
	bool IsHeldByNPC();*/
}