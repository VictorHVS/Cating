using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour {
	private Ray inputRay;
	private RaycastHit inputHit;
	private bool inClick = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetMouseButtonDown(0)){
			inClick = true;
		}
		
		inputRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(inputRay, out inputHit, Mathf.Infinity)){
			if(inputHit.transform.tag == "Button")
				inputHit.transform.SendMessage("OnMouseOver", SendMessageOptions.RequireReceiver);
			if(inputHit.transform.tag == "Button" && inClick == true)
				inputHit.transform.SendMessage("OnClick", SendMessageOptions.RequireReceiver);
		}
		
		inClick = false;
	
	}
}
