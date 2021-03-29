using UnityEngine;
using System.Collections;

public class Trap2 : MonoBehaviour {

	public GameObject ShootSpawn;
	public GameObject Shell;
	public float Speed = 1000f;
	void OnTriggerEnter (Collider other)
	{
		if(other.tag == "Igrac")
		{
			Instantiate (Shell, ShootSpawn.transform.position + Vector3.forward, ShootSpawn.transform.rotation);

			
		}
	}

}
