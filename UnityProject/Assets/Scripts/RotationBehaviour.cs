using UnityEngine;
using System.Collections;

public class RotationBehaviour : MonoBehaviour {

	public float SpeedRotationX;
	public float SpeedRotationY;
	public float SpeedRotationZ;
	public int day;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (SpeedRotationX, SpeedRotationY, SpeedRotationZ);
		if (transform.localEulerAngles.y == 100.0) {
			day += 1;		
		}
		print(day.ToString());
	}
}
