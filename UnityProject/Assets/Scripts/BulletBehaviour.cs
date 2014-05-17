using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {

	public float speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//moveDirection = transform.TransformDirection(moveDirection);
		transform.Translate (0, speed, 0);
	}
}
