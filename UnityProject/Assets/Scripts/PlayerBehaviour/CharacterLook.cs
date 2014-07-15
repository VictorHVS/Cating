using UnityEngine;
using System.Collections;

public class CharacterLook : MonoBehaviour {

	private Vector3 rightDirection;
	private Vector3 leftDirection;

	void Start () {
		rightDirection = transform.localScale;
		leftDirection = transform.localScale;
		leftDirection.x *= -1;
	}

	void Update () {
		if(Input.GetAxis ("Horizontal") < 0){
			transform.localScale = leftDirection;
		}if(Input.GetAxis ("Horizontal") > 0){
			transform.localScale = rightDirection;
		}
	}
}
