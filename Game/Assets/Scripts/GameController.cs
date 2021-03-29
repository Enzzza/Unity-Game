using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{	


	public GUIText restartText;
	public GUIText gameOverText;
	public bool gameOver;
	public bool restart;
	public GameObject GuiDisplayGameObject;



	void Start()
	{
		gameOver = false;
		restart = false;
		restartText.text = "";
		gameOverText.text = "";


	}
	void Update ()
	{



	
		if (gameOver)
		{
			restartText.text = "Press 'R' for Restart";
			restart = true;

		}

		if (restart)
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}
	}
	public void GameOver()
	{
		gameOverText.text = "Game Over";
		gameOver = true;


	}

}
