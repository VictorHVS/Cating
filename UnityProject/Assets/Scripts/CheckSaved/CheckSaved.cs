using UnityEngine;
using System.Collections;

public class CheckSaved : MonoBehaviour {
	public string  yourName;
	public string currentLevel;

	// Use this for initialization
	void Start () {
		if(databaseUser0.CheckPersistence()){
			yourName = databaseUser0.GetName();
			currentLevel = databaseUser0.Getlevel();
		}else{
			databaseUser0.setName("Digite seu nome");
			yourName = databaseUser0.GetName();
			databaseUser0.setlevel("Level0");
			currentLevel = databaseUser0.Getlevel();
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		yourName = GUI.TextField(new Rect(100, 100, 200, 20), yourName, 25);

		if (GUI.Button (new Rect (350, 100, 50, 20), "Load")) {
			databaseUser0.setName(yourName);
			Application.LoadLevel (currentLevel);
		}
			
		if (GUI.Button (new Rect (300, 100, 50, 20), "Clear")) {
			databaseUser0.DeleteAll();
			yourName = databaseUser0.GetName();
			currentLevel = databaseUser0.Getlevel();

		}
		
			

	}


}
