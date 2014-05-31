using UnityEngine;
using System.Collections;

public class PlayerRotate : MonoBehaviour {

	private bool moveRight;
	private bool moveLeft;
	private float angleRotate;
	private bool unBug;
	private float y;
	private float targetSpeed;
	private CharacterMotor motor;


	public int speed = 80;
	public int angle = 90;
	
	void Start () {

	}

	void Update () {
		motor = transform.GetComponent<CharacterMotor> ();

		if (Input.GetKeyDown ("z") && !moveLeft) {
			moveRight = true;
			if(motor.enabled)
				motor.enabled = false;
		}
		if (Input.GetKeyDown ("x") && !moveRight) {
			moveLeft = true;
			if(motor.enabled)
				motor.enabled = false;	
		}
		if (moveRight)
			moveRotateRight ();
		if (moveLeft)
			moveRotateLeft ();
	}

	void moveRotateRight (){
		transform.Rotate (0, speed * Time.deltaTime , 0);
		angleRotate += speed * Time.deltaTime;
		if(angleRotate >= angle){
			angleRotate -= angle;
			unBug = true;
			moveRight = false;
			if(!motor.enabled)
				motor.enabled = true;
			if (unBug) {
				transform.Rotate (0,-angleRotate,0);
				angleRotate = 0;
				unBug = false;
			}
		}
	}
	void moveRotateLeft (){
		transform.Rotate (0, -speed * Time.deltaTime , 0);
		angleRotate+= speed * Time.deltaTime;
		if(angleRotate >= angle){
			angleRotate -= angle;
			unBug = true;
			moveLeft = false;
			if(!motor.enabled)
				motor.enabled = true;
			if (unBug) {
				transform.Rotate (0,angleRotate,0);
				angleRotate = 0;
				unBug = false;
			}
		}
	}

}
