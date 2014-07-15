using UnityEngine;
using System.Collections;

public class LoadBehaviour : MonoBehaviour {
	private float time = 0;
	public float maxTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if(time > maxTime)
			Application.LoadLevel ("Menu");
	}
}
