using UnityEngine;
using System.Collections;

public class CharacterMotor : MonoBehaviour {

	public float speed;
	public float jumpForce;
	public float gravity;
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;
	
	private bool moveRight = false;
	private bool moveLeft = false;
	
	private Vector3 rightDirection;
	private Vector3 leftDirection;
	public Transform mesh;


	void Start () {
		controller = GetComponent<CharacterController>();
		rightDirection = mesh.localScale;
		leftDirection = mesh.localScale;
		leftDirection.x *= -1;
		
	}

	void Update () { 
		movePlayer ();
		moveRotate ();
		
	}
	

	
	void moveRotate (){
		if (moveRight) {
			transform.Rotate (0, 90, 0);
			moveRight = false;
		}else if(moveLeft){
			transform.Rotate (0, -90, 0);
			moveLeft = false;
		}
		
		
		if (Input.GetKeyDown ("z") && !moveLeft) {
			moveRight = true;
		}
		if (Input.GetKeyDown ("x") && !moveRight) {
			moveLeft = true;
		}
	}
	
	void movePlayer(){
		if(Input.GetAxis ("Horizontal") < 0){
			transform.localScale = leftDirection;
		}if(Input.GetAxis ("Horizontal") > 0){
			transform.localScale = rightDirection;
		}
		
		
		if (transform.localEulerAngles.y == 0.0) {
			moveDirection.x = Input.GetAxis ("Horizontal") * speed;
			if (controller.isGrounded) {
				moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
				//moveDirection = transform.TransformDirection(moveDirection);
				moveDirection *= speed;
				if (Input.GetButton("Jump"))
					moveDirection.y = jumpForce;
				moveDirection.x = Input.GetAxis ("Horizontal") * speed;
				
			}
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
			
			
		}else if (transform.localEulerAngles.y == 180.0) {
			moveDirection.x = Input.GetAxis ("Horizontal") * speed * -1;
			if (controller.isGrounded) {
				moveDirection = new Vector3(Input.GetAxis("Horizontal")  * -1, 0, 0);
				//moveDirection = transform.TransformDirection(moveDirection);
				moveDirection *= speed;
				if (Input.GetButton("Jump"))
					moveDirection.y = jumpForce;
				moveDirection.x = Input.GetAxis ("Horizontal")  * -1* speed;
				
			}
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
			
			
		}else if (transform.localEulerAngles.y > 89.0 && transform.localEulerAngles.y < 91.0) {
			moveDirection.z = Input.GetAxis ("Horizontal") * -1 * speed;
			if (controller.isGrounded) {
				moveDirection = new Vector3(0, 0,Input.GetAxis("Horizontal") * -1);
				//moveDirection = transform.TransformDirection(moveDirection);
				moveDirection *= speed;
				if (Input.GetButton("Jump"))
					moveDirection.y = jumpForce;
				moveDirection.z = Input.GetAxis ("Horizontal") * -1 * speed;
				
			}
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
			
			
		}else if(transform.localEulerAngles.y == 270.0){
			moveDirection.z = Input.GetAxis ("Horizontal") * speed;
			if (controller.isGrounded) {
				moveDirection = new Vector3(0, 0, Input.GetAxis("Horizontal"));
				moveDirection *= speed;
				if (Input.GetButton("Jump"))
					moveDirection.y = jumpForce;
				moveDirection.z = Input.GetAxis ("Horizontal") * speed;
				
			}
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
			
		}
	}
}

