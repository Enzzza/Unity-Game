using UnityEngine;
using System.Collections;

public class GuiDisplay : MonoBehaviour {
	public GUIText gameGoal;
	public GUIText livesText;
	public GUIText scoreText;
	public GUIText levelText;
	public GameObject GameObjectPlayer;
	public int score;
	public int lives;
	static int level;
	private Igrac igrac;


	void Awake()
	{
		igrac = GameObjectPlayer.GetComponent<Igrac>();


	}
	 void Start () 
	{
		score = igrac.score;
		lives = igrac.lives;
		if (Application.loadedLevelName == "Level 1")
						level = 1;
		else if (Application.loadedLevelName == "Level 2")
						level = 2;
		SetScoreText ();
		SetLivesText ();
		SetLevelText ();
		SetGoalText ();

	}

	
	public void SetScoreText()
	{
		scoreText.text = "Score:" + igrac.score.ToString ();
		
		
		
	}
	public void SetLivesText()
	{
		livesText.text = "Lives:" + igrac.lives.ToString ();
		
		
		
	}
	public void SetLevelText()
	{
		levelText.text = "Level:" + level.ToString();
		
		
		
	}
	public void SetGoalText()
	{
		gameGoal.text ="Get the key!";
		
	}
	public void LevelUp()
	{
		level += 1;

	}
	public int GetLevel()
	{
		return level;


	}
}
