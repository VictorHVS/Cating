using UnityEngine;
using System.Collections;

public class Text3DCurrentCube : Text3dBehavior {
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		SetValueText (CurrentDatabase.currentCubes);
	}

}
