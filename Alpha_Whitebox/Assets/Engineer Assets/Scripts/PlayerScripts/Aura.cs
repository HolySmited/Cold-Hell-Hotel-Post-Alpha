using UnityEngine;
using System.Collections;
using HighlightingSystem;

public class Aura : MonoBehaviour 
{
	Highlighter highlight;
	bool highlightOn, stop;
	Highlighter[] children;

	void Start () 
	{
		highlight = GetComponent<Highlighter>();
		highlight.SeeThroughOn();
		highlight.ConstantOn();
		children = GetComponentsInChildren<Highlighter>();
	}

	void Update () 
	{
		if(!highlightOn && !stop)
		{
			highlight.Off();
			highlight.SeeThroughOff();

			foreach(Highlighter highlighter in children)
			{
				if(highlighter.name == "KillBox")
					continue;
				highlighter.Off();
				highlighter.SeeThroughOff();
			}

			stop = true;
		}else if(highlightOn && !stop)
		{
			highlight.ConstantOn(Color.red);
			highlight.SeeThroughOn();

			foreach(Highlighter highlighter in children)
			{
				if(highlighter.name == "KillBox")
					continue;
				highlighter.ConstantOnImmediate();
				highlighter.SeeThroughOn();
			}

			stop = true;
		}
	}

	public void ghostVisionToggle()
	{
		highlightOn = !highlightOn;
		stop = false;
	}

}
