using UnityEngine;
using System.Collections;

public class CameraPlayerBehaviour : MonoBehaviour {
	public GameObject Player;

	private float distanceX;
	private float distanceY;

	void Start () {
		
	}
	void Update () {
		distanceX = transform.position.x - Player.transform.position.x;
		print (transform.position.x - Player.transform.position.x);

		if(distanceX > 2){
			distanceX -= 2;
			transform.Translate(-distanceX , 0, 0);
		}
		if(distanceX < -2){
			distanceX += 2;
			transform.Translate(-distanceX , 0, 0);
		}
	}
}
