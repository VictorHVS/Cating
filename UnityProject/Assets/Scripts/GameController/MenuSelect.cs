using UnityEngine;
using System.Collections;

public class MenuSelect : MonoBehaviour {
	private int value;
	private int opMax = 1;
	public Camera mainCamera;

	public GameObject homeOp0;
	public GameObject homeOp1;

	void Start () {
		value = opMax;
	}

	void Update () {
		ChangeColor ();
		ChangeMenu (opMax);
		if(value == 0){
			if (Input.GetKeyDown (KeyCode.Space)){
				//mainCamera.GetComponent<SoundEfect> ().SoundSelectOP ();
				Quit();			
			}
		}else if(value == 1){
			if (Input.GetKeyDown (KeyCode.Space)){
				//mainCamera.GetComponent<SoundEfect> ().SoundSelectOP ();
				Application.LoadLevel ("Level1");
			}
		}
	}

	public void Quit(){
		Application.Quit();
	}

	public void ChangeColor(){
		if(value == 0){
			homeOp0.renderer.material.color = Color.black;
			homeOp1.renderer.material.color = Color.white;
		}else if(value == 1){
			homeOp0.renderer.material.color = Color.white;
			homeOp1.renderer.material.color = Color.black;
		}
	}

	public void ChangeMenu(int opMax){
		if (Input.GetKeyDown (KeyCode.UpArrow))
			if (value < opMax)
				value++;
		if (Input.GetKeyDown (KeyCode.DownArrow))

			if (value > 0)
				value--;
	}
}
