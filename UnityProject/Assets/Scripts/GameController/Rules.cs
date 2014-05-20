using UnityEngine;
using System.Collections;

public class Rules : MonoBehaviour {

	public GameObject Player;
	public int Level;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		respawn();
	}

	void respawn ()
	{
		if (Player.transform.localPosition.y < -5) {
			Application.LoadLevel ("Level"+Level);
		}
	}
}
