using UnityEngine;
using System.Collections;

public class DayBehaviour : MonoBehaviour {

	public float dayDuration;
	private float speedRotate;
	//public  GameObject light;

	void Start () {
		speedRotate = 360/dayDuration*Time.deltaTime;
	}

	void Update () {

		//light.color -= Color.white / 4.0F * Time.deltaTime;
		light.intensity *= 0.99f;

	}

	void Rotate(){
		transform.Rotate(speedRotate,0,0);
	}

	void CountDays (){
	}


}