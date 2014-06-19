using UnityEngine;
using System.Collections;

public class Rules : MonoBehaviour {

	public float speedHours;
	public float hour;
	public int cubes;
	private GameObject player;

	//escrever as propriedade das duas variaveis abaixo
	public Vector3 checkPointPosition;
	public Quaternion checkPointRotate;
	
	void Start () {
		player = GameObject.Find ("Player");
		cubes = databaseUser0.GetCube ();
	}
	
	void Update () {
		respawn ();
		hour += speedHours * Time.deltaTime;
		if(hour > 24){
			hour -= 24;
		}
	}

	public void setCube(int cube){
		this.cubes = cube;
	}

	void respawn (){
		if(player != null)
			if (player.transform.localPosition.y < -20) {
				player.transform.position = checkPointPosition;
				player.transform.localRotation = checkPointRotate;
			}
	}


}
