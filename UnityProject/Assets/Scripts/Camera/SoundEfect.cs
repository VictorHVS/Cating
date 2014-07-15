using UnityEngine;
using System.Collections;

public class SoundEfect : MonoBehaviour {

	public AudioClip soundCheckpoint;
	public AudioClip soundChangePespective;
	public AudioClip soundSelectOP;
	public AudioClip soundNewOP;

	public void SoundCheckpoint(){
		audio.clip = soundCheckpoint;
		audio.Play ();
	}
	public void SoundChangePespective(){
		audio.clip = soundChangePespective;
		audio.Play ();
	}
	public void SoundNewOP(){
		audio.clip = soundNewOP;
		audio.Play ();
	}
	public void SoundSelectOP(){
		audio.clip = soundSelectOP;
		audio.Play ();
	}
}
