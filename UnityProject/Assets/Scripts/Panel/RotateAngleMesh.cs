using UnityEngine;
using System.Collections;

public class RotateAngleMesh : MonoBehaviour {

	
	public float speed = 250;
	public float angle = 360;
	
	private float angleRotate;
	private bool rotate;

	void Start () {
	
	}

	void Update () {
		Rotate ();
	}
	
	public void Rotate(){
		if(rotate){
			transform.Rotate (0, 0, speed * Time.deltaTime);
			angleRotate += speed * Time.deltaTime;
			if(angleRotate >= angle){
				angleRotate = 0;
				rotate = false;
			}
		}
	}

	public void setRotate (bool value){
		rotate = value;
	}

}
