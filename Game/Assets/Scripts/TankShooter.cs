using UnityEngine;
using System.Collections;

public class TankShooter : MonoBehaviour 
{
	public Transform ShootSpawn1;
	public Transform ShootSpawn2;
	public GameObject Shell1;
	public GameObject Shell2;
	public float fireRate = 1.5f;
	public float nextFire = 0.0f;

	void Update () 
	{	
		if (Time.time > nextFire)
		{
						nextFire = Time.time + fireRate;
						Instantiate (Shell1, ShootSpawn1.position + Vector3.forward, ShootSpawn1.rotation);
						Instantiate (Shell2, ShootSpawn2.position +Vector3.forward, ShootSpawn2.rotation);
		}

		
	}
}