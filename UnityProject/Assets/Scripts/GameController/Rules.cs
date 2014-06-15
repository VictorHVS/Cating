using UnityEngine;
using System.Collections;

public class Rules : MonoBehaviour {

	public float speedHours;
	public float hour;
	public int cube;
	
	void Start () {
		cube = databaseUser0.GetCube ();
	}
	
	void Update () {

		hour += speedHours * Time.deltaTime;
		if(hour > 24){
			hour -= 24;
		}
	}

	public void setCube(int cube){
		this.cube = cube;
	}


}
