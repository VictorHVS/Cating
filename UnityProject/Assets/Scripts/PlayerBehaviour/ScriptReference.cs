using UnityEngine;
using System.Collections;

public class ScriptReference : MonoBehaviour {

	public float speed = 8.0F;
	public float jumpSpeed = 12.0F;
	public float gravity = 26.0F;
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;

	void Start () {
		controller = GetComponent<CharacterController>();
	}

	void Update () {
		print ("x: "+moveDirection.x + "  z: "+moveDirection.z);
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump")){
				moveDirection.y = jumpSpeed;
			}
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
}
