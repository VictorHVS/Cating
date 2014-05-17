using UnityEngine;
using System.Collections;

public class SpawnBulletBehaviour : MonoBehaviour {

	public GameObject bulletPrefab;
	private int i=0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(i < 3){
			Instantiate(bulletPrefab , transform.position, transform.rotation);
			i++;
		}
			



	}
}
