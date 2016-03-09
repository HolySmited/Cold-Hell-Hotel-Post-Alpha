using UnityEngine;
using System.Collections;

public class KillFrankie : MonoBehaviour 
{
	private bool startGameoverTimer, gameOver;
	private float timer, timeLimit;

	void Start () 
	{
		timer = 0f;
		timeLimit = 2f;
	}

	void Update () 
	{
		if(startGameoverTimer && timeLimit < (timer += Time.deltaTime))
		{
			GameObject.FindObjectOfType<GameEndScreen>().activateGameOverScreen();
			timer = 0;
			gameOver = true;
		}
	}

	void OnCollisionEnter(Collision other)
	{
		Debug.Log("Enter");
		if(other.transform.GetComponent<ObjectBehavior>() != null)
		{
			Debug.Log("Behave");
			if(other.transform.GetComponent<ObjectBehavior>().trait_Sharp ||
			   other.transform.GetComponent<ObjectBehavior>().trait_Severable)
			{
				Debug.Log("Kill");
				transform.parent.GetComponent<LivingSight>().Murder();
				startGameoverTimer = true;
			}
		}
	}
}
