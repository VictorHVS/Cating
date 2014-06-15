using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour {


	private float randomX ;
	private float randomY ;
	public float vibration = 0.01f;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		ShakeIt ();
	}

	public void ShakeIt(){
		randomX = Random.Range(-vibration,vibration);
		randomY = Random.Range(-vibration,vibration);
		transform.position += new Vector3 (randomX , randomY, 0);
	}
}
