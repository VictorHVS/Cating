using UnityEngine;
using System.Collections;

public class CollisonBehaviour : MonoBehaviour {

	public GameObject gameController;
	public GameObject CubePanel;
	private Rules rules;
	public AudioClip soundcube;

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
			hit.GetComponent<AudioSource>().clip = soundcube;
			hit.GetComponent<AudioSource>().Play();
			CubePanel.GetComponent<RotateAngleMesh>().setRotate(true);
			Destroy(hit.gameObject);
			CurrentDatabase.currentCubes++;
		}
		if(hit.transform.tag == "Portal"){
			databaseUser0.setCube(gameController.GetComponent<Rules>().cubes);
			Application.LoadLevel ("MapLevel");
			Destroy(hit.gameObject);
		}

	}


}

