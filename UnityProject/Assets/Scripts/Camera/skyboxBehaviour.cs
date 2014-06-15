using UnityEngine;
using System.Collections;

public class skyboxBehaviour : MonoBehaviour {

	public Color skyDay;
	public Color skyNight;
	public GameObject gameController;
	private bool isNight;
	private bool isDay;
	public Camera mainCamera;

	void Start () {
		mainCamera.backgroundColor = skyDay;
	}

	void Update () {
		if(gameController.GetComponent<Rules> ().hour > 5 && gameController.GetComponent<Rules> ().hour < 17.5 ){
			mainCamera.backgroundColor = Color.Lerp (mainCamera.backgroundColor, skyDay, gameController.GetComponent<Rules> ().speedHours * Time.deltaTime);
		}else{
			mainCamera.backgroundColor = Color.Lerp (mainCamera.backgroundColor, skyNight, gameController.GetComponent<Rules> ().speedHours * Time.deltaTime);
		}

	}


}
