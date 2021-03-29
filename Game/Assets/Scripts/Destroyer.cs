using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {


	public GameObject GuiGameObject;
	public Transform StartPosition;
	public GameObject GameObjectPlayer;
	private Igrac igrac;
	private GuiDisplay guiDisplay;
	private GameController gameController;





	private TankShooter tankshooter;




	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}
	}
	void Awake()
	{
		igrac = GameObjectPlayer.GetComponent<Igrac>();
		guiDisplay = GuiGameObject.GetComponent<GuiDisplay> ();


	}

	public void Destroy(Collider other)
	{
		igrac.lives -= 1;
		guiDisplay.SetLivesText ();
		float x = StartPosition.transform.position.x;
		float y = StartPosition.transform.position.y;
		float z = StartPosition.transform.position.z;
		if (igrac.lives == 0) 
		{
			gameController.GameOver();
		}
		
		other.transform.position = new Vector3 (x,y,z);
		other.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
		other.GetComponent<Rigidbody>().angularVelocity = new Vector3 (0, 0, 0);



	}


	

	




}
