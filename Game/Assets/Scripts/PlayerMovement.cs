using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{	

	private Igrac igrac;
	private GuiDisplay guiDisplay;
	private GameController gameController;
	public GameObject GuiGameObject;
	public float speed = 10;
	public AudioClip coin;
	public AudioClip life;
	public GameObject PickUp;
	public GameObject PickUpHeart;
	public GameObject PickUpKey;
	public Texture keyIcon;
	public Texture emptyKey;
	public bool isCarryingKey = false;
	public GameObject Door;
	void OnGUI()
	{


		Rect r = new Rect (Screen.width - 70, 40, 100, 64);
		GUILayout.BeginArea (r);
		GUILayout.BeginHorizontal ();

		if (isCarryingKey) 
		{
			GUILayout.Label (keyIcon);
			
		}
		else 
		{
			GUILayout.Label(emptyKey);
		}
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
		GUILayout.EndArea ();
		
	}

	
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
		igrac = GetComponent<Igrac>();
		guiDisplay = GuiGameObject.GetComponent<GuiDisplay> ();
	}
	void FixedUpdate () 
	{
		if (!gameController.gameOver) 
		{
						float moveHorizontal = Input.GetAxis ("Horizontal");
						float moveVertical = Input.GetAxis ("Vertical");
						Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
						GetComponent<Rigidbody>().AddForce (movement * speed);
		}

	}
	void OnCollisionEnter(Collision other) 
	{
		if (other.gameObject.tag == "Door" && isCarryingKey == true) 
		{
			int lvl = guiDisplay.GetLevel();
			if(lvl==1)
				Door.GetComponent<Animation>().Play("DoorAnim");
			else if(lvl == 2)
				Door.GetComponent<Animation>().Play("DoorAnim2");
			
		}
		
	}
	void OnTriggerEnter (Collider other) 
	{
		if (other.gameObject.tag == "Coin1") {
						GetComponent<AudioSource>().PlayOneShot (coin);
						igrac.score += 5;
						guiDisplay.SetScoreText ();
						Quaternion rotation = new Quaternion (0, 1, 0, 0);
						GameObject clone = Instantiate (PickUp, other.transform.position, rotation)as GameObject;
						Destroy (clone, 3);
						Destroy (other.gameObject);
				


				} else if (other.gameObject.tag == "Coin2") {
						GetComponent<AudioSource>().PlayOneShot (coin);
						igrac.score += 10;
						guiDisplay.SetScoreText ();
						Quaternion rotation = new Quaternion (0, 1, 0, 0);
						GameObject clone = Instantiate (PickUp, other.transform.position, rotation) as GameObject;
						Destroy (clone, 3);
						Destroy (other.gameObject);

				} else if (other.gameObject.tag == "Life") {
						GetComponent<AudioSource>().PlayOneShot (life);
						igrac.lives += 1;
						guiDisplay.SetLivesText ();
						Quaternion rotation = new Quaternion (0, 1, 0, 0);
						GameObject clone = Instantiate (PickUpHeart, other.transform.position, rotation) as GameObject;
						Destroy (clone, 3);
						Destroy (other.gameObject);
				} else if (other.gameObject.tag == "Key") {
			
						isCarryingKey = true;
						Quaternion rotation = new Quaternion (0, 1, 0, 0);
						
						GameObject clone = Instantiate (PickUpKey, other.transform.position, rotation) as GameObject;
						Destroy(clone,3);
						Destroy (other.gameObject);
			
				} 
	}

}
