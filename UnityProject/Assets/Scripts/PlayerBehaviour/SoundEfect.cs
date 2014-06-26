using UnityEngine;
using System.Collections;

public class SoundEfect : MonoBehaviour {

	public AudioClip soundCheckpoint;
	public AudioClip soundChangePespective;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SoundCheckpoint(){
		audio.clip = soundCheckpoint;
		audio.Play ();
	}
	public void SoundChangePespective(){
		audio.clip = soundChangePespective;
		audio.Play ();
	}
}
