using UnityEngine;
using System.Collections;

public class RotationBehaviour : MonoBehaviour {

	public float SpeedRotationX;
	public float SpeedRotationY;
	public float SpeedRotationZ;
	public GameObject GameController;

	// Use this for initialization
	void Start () {
		GameController = GameObject.Find ("GameController");
	}
	
	// Update is called once per frame
	void Update () {
		if(!GameController.GetComponent<InputPlataform>().pause)
			transform.Rotate (SpeedRotationX, SpeedRotationY, SpeedRotationZ);
	}
}
