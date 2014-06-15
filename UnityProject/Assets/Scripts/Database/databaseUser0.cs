using UnityEngine;
using System.Collections;

public static class databaseUser0 {

	public static void setName(string name){
		PlayerPrefs.SetString("Name", name);
	}

	public static void setCube(int cube){
		PlayerPrefs.SetInt ("NumberOfCubes", 0);
	}

	public static void setlevel(string nameLevel){
		PlayerPrefs.SetString ("Level", nameLevel);
	}

	public static bool CheckPersistence (){
		if(PlayerPrefs.GetString("Name") != null){
			return true;
		}else{
			return false;
		}
	}

	public static string GetName (){
		return PlayerPrefs.GetString ("Name");
	}

	public static int GetCube (){
		return PlayerPrefs.GetInt ("NumberOfCubes");
	}

	public static string Getlevel(){
		return PlayerPrefs.GetString("Level");
	}

	public static void DeleteAll (){
		PlayerPrefs.DeleteAll ();
		setlevel("Level0");
		setName("Digite seu nome");
		databaseUser0.setlevel("Level0");
	}

}
