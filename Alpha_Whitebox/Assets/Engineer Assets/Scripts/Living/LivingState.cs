using UnityEngine;
using System.Collections;

//manages the AI's fear while in different states
public class LivingState : MonoBehaviour {
	
	private LivingSettings settings;
	private AudioSource source;
	private float calmCounter;
	

	void Start() {
		settings = GetComponent<LivingSettings> ();
		settings.stress = 40;
		source = this.GetComponent<AudioSource> ();
		source.loop = true;
		source.clip = settings.heartbeat;
		source.Play ();
	}

	void Update(){
		//UpdateCalm ();

	}

	void UpdateCalm(){
		calmCounter += Time.deltaTime;
		if (calmCounter > settings.calmTimer) {
			calmCounter = 0;
			ReduceStress();
		}
	}

	void ReduceStress(){
		switch (settings.fearState) {
			case LivingSettings.FearState.calm:
				settings.stress = Mathf.Max(0, settings.stress--);
				break;
			case LivingSettings.FearState.nervous:
				settings.stress = Mathf.Max(settings.nervous, settings.stress-settings.decay);
				break;
			case LivingSettings.FearState.scared:
				settings.stress = Mathf.Max(settings.scared, settings.stress-settings.decay);
				break;
			case LivingSettings.FearState.terrified:
				settings.stress = Mathf.Max(settings.terrified, settings.stress-settings.decay);
				break;
		}
	}

	public void AddFear(int i){
		settings.stress += i;
		if (settings.stress >= settings.terrified) {
			settings.fearState = LivingSettings.FearState.terrified;
			source.Stop();
			source.clip = settings.scream;
			source.Play();
		}
	}




}
