using UnityEngine;
using System.Collections;

public interface IAI
{
	// AI will move to the given position
	void GoTo(Vector3 pos);

	// The given animation will play for one loop
	void AnimationPlayOnce(string animName);

	// The given animation will loop for the given amount of time
	void AnimationPlayForTime(float time, string animName);

	// The given animation will play until explicitly stopped by AnimationStop
	void AnimationPlayForever(string animName);

	// Stop the given animation
	void AnimationStop(string animName);

	// Stop the given animation after the given amount of time has passed
	void AnimationStopInTime(float time, string animName);

	// Stop all currently playing animations
	void AnimationStopAll();

	// Pause the given animation wherever it is at in the loop until is is explicitly resumed by AnimationResume
	void AnimationPause(string animName);

	// Pause the given animation for the given amount of time, then resume the animation
	void AnimationPauseForTime(float time, string animName);

	// Resume a paused animation
	void AnimationResume(string animName);

	// Return the linear distance this AI is from the given position
	float GetDistanceFrom(Vector3 pos);

	// Return true if the AI is within the given distance from the given position
	bool isWithinDistanceFrom(float dist, Vector3 pos);

	// Make AI follow the given path
	void PathFollow(string path);

	// Make AI follow the given path for the given amount of time, then return to the current path
	void PathFollowForTime(float time, string path);

	// Make AI follow the given path after continuing the current path for the given time
	void PathFollowInTime(float time, string path);

	// Make AI start the current path from the first point on the path
	void PathStartCurrentOver();

	// Return the name of the path the AI is currently on
	string PathGetCurrent();

	// Make the AI stop moving and stand where they are until explicitly resumed by MovementResume
	void MovementPause();

	// Make the AI stop moving and stand where they are for the given amount of time
	void MovementPauseForTime(float time);

	// Make the AI resume movement
	void MovementResume();

	// Play the given audio clip as dialogue
	void Speak(string clipName);

	// Play a random clip from the given type of sound
	void SpeakRandom(string soundType);

	// Make any playing audio stop after its loop is completed
	void SpeakStop();

	// Make any playing audio immediately stop
	void SpeakStopImmediate();

	// Send the AI to the given objects position and interact with it, e.g. Turn on a light switch
	void InteractWith(InteractableObject obj);

	// Return true if the player can see this AI
	bool IsInViewOfPlayer();

	// Return true if AI is in the given room
	bool IsInRoom(string roomName);

	// Return the name of the room the AI currenlty is in
	string GetRoom();

	// Make the AI move randomly around the entire hotel
	void Wander();

	// Make the AI move randomly around the current room
	void WanderInCurrentRoom();

	// Send the AI to the given room and make them wander within that room
	void WanderInRoom(string roomName);

	// Send the AI to the entrance of the given room
	void GoToRoom(string roomName);
}
