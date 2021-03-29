using UnityEngine;
using System.Collections;

public class TurnOffFire : MonoBehaviour {
	public GameObject Player;
	private PlayerMovement playerMovement;

	void Awake()
	{	
		playerMovement =Player.GetComponent<PlayerMovement> ();


	}

	void Update()
	{
		if (playerMovement.isCarryingKey) 
		{
			gameObject.SetActive (false);
		}

	}
}
