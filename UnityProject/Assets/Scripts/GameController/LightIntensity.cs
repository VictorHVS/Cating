using UnityEngine;
using System.Collections;

public class LightIntensity : MonoBehaviour {

	public GameObject gameController;
	public float maxIntensity = 1f;
	public float minIntensity = 0.5f;
	private bool isDay = true;
	private bool isNight = false;
	private float speedSunDown;

	void Start () {
	}

	void Update () {
		speedSunDown = gameController.GetComponent<Rules> ().speedHours/40;

		if(gameController.GetComponent<Rules> ().hour > 5 && 
		   gameController.GetComponent<Rules> ().hour < 17.5 && isNight){
			Day();
		}
		if(gameController.GetComponent<Rules> ().hour > 17.5 && isDay){
			Night();
		}
	}
	void Night (){
		if (light.intensity > minIntensity) {
			light.intensity *= 1 - speedSunDown;
		}else{
			isNight = true;
			isDay = false;
		}
	}
	void Day (){
		if(light.intensity < maxIntensity){
			light.intensity *= 1 + speedSunDown;
		}else{
			isDay = true;
			isNight = false;
		}
	}

}