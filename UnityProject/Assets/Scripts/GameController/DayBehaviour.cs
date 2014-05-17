using UnityEngine;
using System.Collections;

public class DayBehaviour : MonoBehaviour {


	private int day = 0;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		CountDays ();

	}

	void CountDays (){
		if (transform.localEulerAngles.y == 1.0 ) {
			day += 1;	
			print ("Day: " + day);
		}


	}
}