using UnityEngine;
using System.Collections;

public class CharacterMotorPreview : MonoBehaviour {

	public float speed = 8;
	public float jumpForce = 12;
	public float gravity = 26;
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;

	void Start () {
		controller = GetComponent<CharacterController>();
	}

	void Update () { 
		movePlayer ();
		//print ("x: "+moveDirection.x + "  z: "+moveDirection.z);

	}

	void movePlayer(){
		//implementar Strategy

		if(transform.localEulerAngles.y < 2 && transform.localEulerAngles.y > -2){
			moveDirection.z = 0;
			moveDirection.x = Input.GetAxis("Horizontal") * speed;
			//moveDirection = transform.TransformDirection(moveDirection);
			moveDirection.y -= gravity * Time.deltaTime;
			if (controller.isGrounded && Input.GetButton("Jump")) {
				moveDirection.y = jumpForce;
			}
			controller.Move(moveDirection * Time.deltaTime);
		}
		else if(transform.localEulerAngles.y < 92 && transform.localEulerAngles.y > 88){
			moveDirection.x = 0;
			moveDirection.z = Input.GetAxis("Horizontal") * -speed;
			moveDirection.y -= gravity * Time.deltaTime;
			if (controller.isGrounded && Input.GetButton("Jump")) {
				moveDirection.y = jumpForce;
			}
			controller.Move(moveDirection * Time.deltaTime);
		}
		else if(transform.localEulerAngles.y < 182 && transform.localEulerAngles.y > 178){
			moveDirection.z = 0;
			moveDirection.x = Input.GetAxis("Horizontal") * -speed;
			moveDirection.y -= gravity * Time.deltaTime;
			if (controller.isGrounded && Input.GetButton("Jump")) {
				moveDirection.y = jumpForce;
			}
			controller.Move(moveDirection * Time.deltaTime);

		}
		else if(transform.localEulerAngles.y < 272 && transform.localEulerAngles.y > 268){
			moveDirection.x = 0;
			moveDirection.z = Input.GetAxis("Horizontal") * speed;
			moveDirection.y -= gravity * Time.deltaTime;
			if (controller.isGrounded && Input.GetButton("Jump")) {
				moveDirection.y = jumpForce;
			}
			controller.Move(moveDirection * Time.deltaTime);
		}
	}
}

