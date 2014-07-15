using UnityEngine;
using System.Collections;


public enum stageGame{
	inGame,
	inPause,
	inTutorial,
	inMenu,
	inAbout
}

public static class CurrentDatabase {
	//gerar propriedades para essas variaveis
	public static string userName;
	public static int currentCubes;
	public static int totalCubes;
	public static string currentLevel;

	public static stageGame state = stageGame.inMenu;

}
