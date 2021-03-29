using UnityEngine;
using System.Collections;

public class Igrac : MonoBehaviour 
{
	public int lives = 5;
	public int score = 0;

	public GameObject AgentGameObject;
	public Transform AgentPosition;
	public GameObject explosion;
	public Transform StartPosition;
	private GuiDisplay guiDisplay;
	public GameObject GuiGameObject;
	private GameController gameController;
	private TankShooter tankshooter;
	public GameObject TankGameObject;
	private bool hitted = false;
	public AudioClip explosionSound;
	private UnityEngine.AI.NavMeshAgent agent;
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
		tankshooter = TankGameObject.GetComponent<TankShooter> ();
		guiDisplay = GuiGameObject.GetComponent<GuiDisplay> ();
		agent = AgentGameObject.GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	void Update()
	{
		if (lives <= 0) 
		{
			gameController.GameOver();
		}

	}
	void OnTriggerEnter (Collider other) 
	{



			
		if (other.gameObject.tag == "Shell1" && hitted == false) {
						
						lives -= 1;
						guiDisplay.SetLivesText ();
						Destroy (other.gameObject);
						GameObject clone = Instantiate (explosion, this.transform.position, this.transform.rotation) as GameObject;
						Destroy (clone, 2f);
						GetComponent<AudioSource>().PlayOneShot (explosionSound);
						Invoke ("RestartPosition", 3f);
						GetComponent<Rigidbody>().isKinematic = true;
						tankshooter.enabled = false;
						hitted = true;
						GetComponent<Renderer>().enabled = false;
				} else if (other.gameObject.tag == "Shell2" && hitted == false) {
						lives -= 1;
						guiDisplay.SetLivesText ();
						Destroy (other.gameObject);
						GameObject clone = Instantiate (explosion, this.transform.position, this.transform.rotation) as GameObject;
						Destroy (clone, 2f);
						GetComponent<AudioSource>().PlayOneShot (explosionSound);
						Invoke ("RestartPosition", 3f);
						GetComponent<Rigidbody>().isKinematic = true;
						tankshooter.enabled = false;
						hitted = true;
						GetComponent<Renderer>().enabled = false;
		
				} else if (other.gameObject.tag == "Crate1" || other.gameObject.tag == "Crate2" || other.gameObject.tag == "Spike1" || other.gameObject.tag == "Spike2" || other.gameObject.tag == "TrapSpike" && hitted == false) {
						lives -= 1;
						guiDisplay.SetLivesText ();
						GameObject clone = Instantiate (explosion, this.transform.position, this.transform.rotation) as GameObject;
						Destroy (clone, 2f);
						GetComponent<AudioSource>().PlayOneShot (explosionSound);
						Invoke ("RestartPosition", 3f);
						GetComponent<Rigidbody>().isKinematic = true;
						tankshooter.enabled = false;
						hitted = true;
						GetComponent<Renderer>().enabled = false;

				} else if (other.gameObject.tag == "Agent") 
				{
						lives -= 1;
						guiDisplay.SetLivesText ();
						GameObject clone = Instantiate (explosion, this.transform.position, this.transform.rotation) as GameObject;
						Destroy (clone, 2f);
						GetComponent<AudioSource>().PlayOneShot (explosionSound);
						GetComponent<Rigidbody>().isKinematic = true;
						hitted = true;
						GetComponent<Renderer>().enabled = false;
						agent.enabled = false;
						agent.transform.position = new Vector3 (AgentPosition.transform.position.x,AgentPosition.transform.position.y,AgentPosition.transform.position.z);
						agent.enabled = true;
						Invoke ("RestartPosition", 3f);
						
						
						
				}
	}
		
	void RestartPosition()
	{

		GetComponent<Rigidbody>().isKinematic= false;
		float x = StartPosition.transform.position.x;
		float y = StartPosition.transform.position.y;
		float z = StartPosition.transform.position.z;
	
		GetComponent<Renderer>().enabled = true;
		transform.position = new Vector3 (x,y,z);
		GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
		GetComponent<Rigidbody>().angularVelocity = new Vector3 (0, 0, 0);
		if(Application.loadedLevelName == "Level 1")
			tankshooter.enabled = true;
	
	
		hitted = false;


	}
}
