using UnityEngine;
using System.Collections;

public class RotationBehaviour : MonoBehaviour {

	public float SpeedRotationX;
	public float SpeedRotationY;
	public float SpeedRotationZ;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (SpeedRotationX, SpeedRotationY, SpeedRotationZ);
	}
}
