using UnityEngine;
using System.Collections;

public static class databaseUser0 {

	public static void saveName(string name){
		PlayerPrefs.SetString("Name", "Insira seu nome");
	}

	public static void saveCube(int cube){
		PlayerPrefs.SetInt ("NumberOfCubes", 0);
	}

}
