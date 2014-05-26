using UnityEngine;
using System.Collections;

public class Rules : MonoBehaviour {
	

	public float speedHours;
	public float hour;
	
	void Start () {
	}
	
	void Update () {
		hour += speedHours * Time.deltaTime;
		if(hour> 24){
			hour -= 24;
		}
	}

}
