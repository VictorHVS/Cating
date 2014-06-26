using UnityEngine;
using System.Collections;

public class PlayerRotate : MonoBehaviour {

	private bool moveRight = false;
	private bool moveLeft = false;
	private float angleRotate;
	private bool unBug;
	private float y;
	private float targetSpeed;

	private float randomX ;
	private float randomY ;
	public float vibration = 0.01f;
	public GameObject shakeObject;

	public int speed = 80;
	public int angle = 90;
	
	void Start () {

	}

	void Update () {

		if(moveLeft){
			moveRotateLeft();

		}else if (moveRight){
			moveRotateRight();

		}

	}
	public void RotateRight(){
		if (!moveLeft) {
			GetComponent<SoundEfect> ().SoundChangePespective ();
			moveRight = true;
		}
	}

	public void RotateLeft(){
		if (!moveRight) {
			GetComponent<SoundEfect> ().SoundChangePespective ();
			moveLeft = true;
		}
	}

	void moveRotateRight (){
		transform.Rotate (0, speed * Time.deltaTime , 0);
		ShakeIt ();
		angleRotate += speed * Time.deltaTime;
		if(angleRotate >= angle){
			angleRotate -= angle;
			unBug = true;
			moveRight = false;
			if (unBug) {
				transform.Rotate (0,-angleRotate,0);
				angleRotate = 0;
				unBug = false;
			}
		}
	}
	void moveRotateLeft (){
		transform.Rotate (0, -speed * Time.deltaTime , 0);
		ShakeIt ();
		angleRotate+= speed * Time.deltaTime;
		if(angleRotate >= angle){
			angleRotate -= angle;
			unBug = true;
			moveLeft = false;
			if (unBug) {
				transform.Rotate (0,angleRotate,0);
				angleRotate = 0;
				unBug = false;
			}
		}
	}

	public void ShakeIt(){
		randomX = Random.Range(-vibration,vibration);
		randomY = Random.Range(-vibration,vibration);
		shakeObject.transform.position += new Vector3 (randomX , randomY, 0);
	}

}
