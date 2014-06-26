using UnityEngine;
using System.Collections;

public class MenuSelect : MonoBehaviour {
	private int value;
	private int opMax = 2;
	private bool isHome = true;

	public GameObject homeOp0;
	public GameObject homeOp1;
	public GameObject homeOp2;

	public GameObject playOp0;
	public GameObject playOp1;

	public GameObject menuHome;
	public GameObject menuPlay;
	public GameObject menuAbout;



	// Use this for initialization
	void Start () {
		value = opMax;

	}
	
	// Update is called once per frame
	void Update () {
		ChangeColor ();
		ChangeMenu (opMax);
		if(value == 0){
			if (Input.GetKeyDown (KeyCode.Space))
				if(isHome)
					Quit();
				else
					Application.LoadLevel(1);
			
		}else if(value == 1){
			if (Input.GetKeyDown (KeyCode.Space))
				if(isHome)
					About();
				else
					Application.LoadLevel(1);
		}else if(value == 2){
			if (Input.GetKeyDown (KeyCode.Space))
				if(isHome)
					PlayGame();
		}
	}

	public void PlayGame(){
		print ("PlayGame");
		opMax = 1;
		value = opMax;
		isHome = false;
		menuPlay.transform.localEulerAngles = menuHome.transform.localEulerAngles;;
		menuHome.transform.localEulerAngles = menuAbout.transform.localEulerAngles;
	}
	public void About(){
		print ("About");
	}
	public void Quit(){
		print ("Quit");
		Application.Quit();
	}

	public void ChangeColor(){
		if(true){
			if(value == 0){
				homeOp0.renderer.material.color = Color.black;
				homeOp1.renderer.material.color = Color.white;
				homeOp2.renderer.material.color = Color.white;

				playOp0.renderer.material.color = Color.black;
				playOp1.renderer.material.color = Color.white;
			}else if(value == 1){
				homeOp1.renderer.material.color = Color.black;
				homeOp0.renderer.material.color = Color.white;
				homeOp2.renderer.material.color = Color.white;

				playOp0.renderer.material.color = Color.white;
				playOp1.renderer.material.color = Color.black;
			}else if(value == 2){
				homeOp2.renderer.material.color = Color.black;
				homeOp0.renderer.material.color = Color.white;
				homeOp1.renderer.material.color = Color.white;
			}
		}
	}

	public void ChangeMenu(int opMax){
		if (Input.GetKeyDown (KeyCode.UpArrow))
			value++;
			if (value > opMax)
				value = 0;
		if (Input.GetKeyDown (KeyCode.DownArrow))
			value--;
			if (value < 0)
				value = opMax;
	}
}
