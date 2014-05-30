using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	public Color emptyCube;
	public Color fullCube;
	public Renderer rendererCube;
	public float duration = 1f;
	void Start () {
		rendererCube.material.color = emptyCube;
	}

	void Update () {
	}

	public void Change() {
		renderer.material.SetColor("_Color", Color.Lerp(emptyCube,fullCube,duration));
	}

}
