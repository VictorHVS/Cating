using UnityEngine;
using System.Collections;

public class ButtonDownBehavior : MonoBehaviour {

	private bool activeButton = false;
	public GameObject portal;
	private float curretTime;
	private Vector3 buttonPosition;

	// Use this for initialization
	void Start () {
		buttonPosition  = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (activeButton) {
			curretTime += Time.deltaTime;
			if(curretTime > 5){
				buttonPosition.y += 0.20f;
				transform.position = buttonPosition;
				curretTime = 0;
				activeButton = false;
			}
		}	
	}

	void OnTriggerEnter(Collider hit){
		if(hit.transform.tag == "Player"){
			if(!activeButton ){
				buttonPosition.y -= 0.20f;
				transform.position = buttonPosition;
				activeButton = true;
				if(CurrentDatabase.currentCubes > 8)
					portal.GetComponent<MeshRenderer>().enabled = true;
			}
		}
	}
}
