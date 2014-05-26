using UnityEngine;
using System.Collections;

public class skyboxBehaviour : MonoBehaviour {

	public Color skyDay;
	public Color skyNight;
	public GameObject gameController;
	private bool isNight;
	private bool isDay;

	void Start () {
		camera.backgroundColor = skyDay;
	}

	void Update () {
		if(gameController.GetComponent<Rules> ().hour > 5 && gameController.GetComponent<Rules> ().hour < 17.5 ){
			camera.backgroundColor = Color.Lerp (camera.backgroundColor, skyDay, gameController.GetComponent<Rules> ().speedHours * Time.deltaTime);
		}else{
			camera.backgroundColor = Color.Lerp (camera.backgroundColor, skyNight, gameController.GetComponent<Rules> ().speedHours * Time.deltaTime);
		}

	}


}
