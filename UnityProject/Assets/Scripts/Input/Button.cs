using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public Material overButton;
	public Material pressButton;
	public Material normalButton;

	private bool isClicked = false;
	private bool isMouseOver = false;
	private bool OffMouseOver = true;

	private float currentTimeAfterClick = 0f;
	private float currentTimeAfterOver = 0f;

	public Renderer rendererButton;

	void Start () {
		rendererButton.material = normalButton;
	}
	
	// Update is called once per frame
	void Update () {
		if(!isMouseOver && !isClicked){
			rendererButton.material = normalButton;
		}

		if(isClicked == true){
			currentTimeAfterClick += Time.deltaTime;
			if(currentTimeAfterClick > 0.1f){
				currentTimeAfterClick = 0;
				isClicked = false;
				if(isMouseOver == false)
					rendererButton.material = normalButton;
				else
					rendererButton.material = overButton;
			}	
			
		}

		OffMouseOver = true;

		if(isMouseOver == true){
			currentTimeAfterOver += Time.deltaTime;
			if(currentTimeAfterOver > 0.4f && OffMouseOver){
				currentTimeAfterOver = 0;
				isMouseOver = false;
				rendererButton.material = normalButton;
			}
			
		}


	}

	void OnClick(){

		isClicked = true;
		rendererButton.material = pressButton;

	}

	void OnMouseOver(){
		OffMouseOver = false;
		isMouseOver = true;
		if (isClicked) {
			rendererButton.material = pressButton;
		} else {
			rendererButton.material = overButton;
		}

	}


}
