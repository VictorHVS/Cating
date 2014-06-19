using UnityEngine;
using System.Collections;

public class Text3dBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetValueText(int value){
		if(value < 10)
			GetComponent<TextMesh>().text = "0" + value.ToString();
		else
			GetComponent<TextMesh>().text = value.ToString();
	}
}
