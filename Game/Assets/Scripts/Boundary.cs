﻿using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour 
{	

	private Destroyer destroyer;
	void Start()
	{
		GameObject DestroyerController = GameObject.FindWithTag ("Destroyer");
		if (DestroyerController != null)
		{
			destroyer = DestroyerController.GetComponent <Destroyer>();
		}
		if (destroyer == null)
		{
			Debug.Log ("Cannot find 'Destroyer' script");
		}
	
	}


	void OnTriggerEnter (Collider other) 
	{	
		if(other.gameObject.tag != "Door")
		destroyer.Destroy (other);




	}
}
	 
	


