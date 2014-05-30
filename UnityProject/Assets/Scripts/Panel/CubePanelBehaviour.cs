using UnityEngine;
using System.Collections;

public class CubePanelBehaviour : MonoBehaviour {

	public float speed = 1;
	public float angle;
	public GameObject MeshColor1;
	public GameObject MeshColor2;
	public GameObject MeshColor3;
	public GameObject MeshColor4;
	public GameObject MeshColor5;

	private float angleRotate;
	private bool rotate;
	private int countCube = 0;

	void Update () {

	}
	
	public void setCountCube (){
		countCube++;
		ChageColor ();
	}

	 void ChageColor (){
		if(countCube == 1){
			MeshColor1.GetComponent<ChangeColor>().Change();
			MeshColor1.GetComponent<RotateAngleMesh>().setRotate(true);
		}else if(countCube == 2){
			MeshColor2.GetComponent<ChangeColor>().Change();
			MeshColor2.GetComponent<RotateAngleMesh>().setRotate(true);
		}else if(countCube == 3){
			MeshColor3.GetComponent<ChangeColor>().Change();
			MeshColor3.GetComponent<RotateAngleMesh>().setRotate(true);
		}else if(countCube == 4){
			MeshColor4.GetComponent<ChangeColor>().Change();
			MeshColor4.GetComponent<RotateAngleMesh>().setRotate(true);
		}else if(countCube == 5){
			MeshColor5.GetComponent<ChangeColor>().Change();
			MeshColor5.GetComponent<RotateAngleMesh>().setRotate(true);
		}
	}
}
