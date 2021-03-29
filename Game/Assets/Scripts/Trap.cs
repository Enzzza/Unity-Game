using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {
	public GameObject trap;
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "Igrac")
		{
			trap.GetComponent<Animation>().Play("TrapAnim");


		}
	}

		


}
