using UnityEngine;
using System.Collections;

public class CollisonBehaviour : MonoBehaviour {

	public GameObject gameController;
	public GameObject CubePanel;
	private Rules rules;

	void Start () {
		gameController.GetComponent<Rules>().checkPointPosition = transform.position;
		rules = gameController.GetComponent<Rules> ();
	}

	void Update () {

	}

	void OnTriggerEnter(Collider hit){

		if(hit.transform.tag == "checkPoint"){
			rules.checkPointPosition = hit.transform.position;
			rules.checkPointRotate = transform.localRotation;
			rules.cubes ++;
			GetComponent<SoundEfect> ().SoundCheckpoint();
			CubePanel.GetComponent<RotateAngleMesh>().setRotate(true);
			Destroy(hit.gameObject);
			CurrentDatabase.currentCubes++;
		}
		if(hit.transform.tag == "Portal"){
			databaseUser0.setCube(gameController.GetComponent<Rules>().cubes);
			Application.LoadLevel ("About");
			Destroy(hit.gameObject);
		}

	}


}

