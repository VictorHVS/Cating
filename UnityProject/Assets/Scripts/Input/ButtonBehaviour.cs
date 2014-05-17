using UnityEngine;
using System.Collections;

public class ButtonBehaviour : MonoBehaviour {
	
	public Material normalButton;
	public Material pressButton;
	public Material overButton;
	private float currentTimeAfterClick;
	private bool isClicked;
	private bool isMouseOver;
	public Renderer rendererButton;
	
	// Use this for initialization
	void Start () {
		rendererButton.material = normalButton;
	
	}
	
	// Update is called once per frame
	void Update () {
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
		if(isMouseOver == true){
			currentTimeAfterClick += Time.deltaTime;
			if(currentTimeAfterClick > 0.1f){
				currentTimeAfterClick = 0;
				isMouseOver = false;
				rendererButton.material = normalButton;
			}
				
		}
	
	}
	
	void OnClick(){
		isClicked = true;
		rendererButton.material = pressButton;
		currentTimeAfterClick = 0;
		
	}
	
	void OnMouseOver(){
		isMouseOver = true;
		if(isClicked == false)
			rendererButton.material = overButton;
	
	}
}
