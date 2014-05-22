using UnityEngine;
using System.Collections;

public class CollisonBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider hit){
		if(hit.transform.tag == "Portal"){
			Application.LoadLevel ("Level1");
			//print ("respawn Level");
			//Destroy(hit.gameObject);
		}
	}
}
