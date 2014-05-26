using UnityEngine;
using System.Collections;

public class CollisonBehaviour : MonoBehaviour {
	
	public int currentLevel;
	private Vector3 checkPointPosition;
	private Quaternion checkPointRotate;

	// Use this for initialization
	void Start () {
		checkPointPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		respawn();
	}

	void OnTriggerEnter(Collider hit){
		if(hit.transform.tag == "checkPoint"){
			checkPointPosition = hit.transform.position;
			checkPointRotate = hit.transform.localRotation;
			Destroy(hit.gameObject);
		}
		if(hit.transform.tag == "portal"){
			Application.LoadLevel ("Level"+(currentLevel+1));
			Destroy(hit.gameObject);
		}
	}

	void respawn (){
		if (transform.localPosition.y < -5) {
			transform.position = checkPointPosition;
			transform.localRotation = checkPointRotate;
		}
	}

}
