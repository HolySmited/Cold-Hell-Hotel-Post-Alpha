using UnityEngine;
using System.Collections;

public interface IUI
{
	// Display the given screen
	void ShowScreen(string screenName);

	// Display the given screen after the given amount of time has passed
	void ShowScreenInTime(float time, string screenName);

	// Display the given screen for the given amount of time, then stop displaying it
	void ShowScreenForTime(float time, string screenName);

	// Display the given screen after the given time "timeWait", for the given time "timeShow"
	void ShowScreenInTimeForTime(float timeWait, float timeShow, string screenName);

	// Stop showing the given screen
	void Remove(string screenName);

	// Stop showing all UI that isn't constantly on screen, e.g. tips
	void RemoveAll();

	// Remove the UI that is constantly on screen, e.g. the reticle
	void RemovePermanentUI();

	// Pause the game in the style of the menu until ResumeGame is called
	void PauseGame();

	// Resumes the game
	void ResumeGame();

	// Return the player to the main menu
	void QuitGame();

	// Reset the current level
	void RestartGame();
}
