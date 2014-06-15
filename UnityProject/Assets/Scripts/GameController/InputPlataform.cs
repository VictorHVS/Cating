using UnityEngine;
using System.Collections;

public class InputPlataform : MonoBehaviour {

	public bool pause = false;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!pause){
			if(Input.GetKeyDown ("z")){
				player.GetComponent<PlayerRotate>().RotateRight();

			}

			if(Input.GetKeyDown ("x")){
				player.GetComponent<PlayerRotate>().RotateLeft();

			}
		}
		if (Input.GetKeyDown ("p")) {
			Pause();
		}
	}

	//refatorar metodo Pause para o script rules
	public void Pause(){
		if(pause == true){
			Time.timeScale = 1;
			pause = false;
		}else{
			Time.timeScale = 0;
			pause = true;
		}
	}

}
