using UnityEngine;
using System.Collections;

public class CollisonBehaviour : MonoBehaviour {
	
	public int currentLevel;
	private Vector3 checkPointPosition;
	private Quaternion checkPointRotate;
	public GameObject gameController;
	public GameObject CubePanel;

	void Start () {
		checkPointPosition = transform.position;
	}

	void Update () {
		respawn();
	}

	void OnTriggerEnter(Collider hit){
		if(hit.transform.tag == "checkPoint"){
			checkPointPosition = hit.transform.position;
			checkPointRotate = transform.localRotation;
			gameController.GetComponent<Rules>().cube ++;
			CubePanel.GetComponent<RotateAngleMesh>().setRotate(true);
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
