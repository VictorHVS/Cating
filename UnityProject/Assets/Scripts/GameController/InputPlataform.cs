using UnityEngine;
using System.Collections;

public class InputPlataform : MonoBehaviour {

	public bool pause = false;
	public GameObject player;
	public Renderer pauseScreen;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!pause){
			if(Input.GetKeyDown ("z")){
				if(player != null)
					player.GetComponent<PlayerRotate>().RotateRight();
			}

			if(Input.GetKeyDown ("x")){
				if(player != null)
					player.GetComponent<PlayerRotate>().RotateLeft();
			}

		}
		if (Input.GetKeyDown ("p")) {
			pauseScreen.enabled = !pauseScreen.enabled;
			Pause();

		}
		if (Input.GetKeyDown(KeyCode.Escape) && Application.loadedLevel != 1) {
			Application.LoadLevel ("Menu");

		}
		if (Input.anyKeyDown && Application.loadedLevel == 2) {
			Application.LoadLevel ("Menu");
			
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
