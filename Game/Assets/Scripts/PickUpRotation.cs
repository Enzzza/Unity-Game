using UnityEngine;
using System.Collections;

public class PickUpRotation : MonoBehaviour {

	public float x = 0;
	public float y = 0;
	public float z = 60;


	void Update () 
	{
	
		transform.Rotate (new Vector3(x,y,z)*Time.deltaTime);

	}
}
