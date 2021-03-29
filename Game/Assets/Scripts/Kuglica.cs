using UnityEngine;
using System.Collections;

public class Kuglica : MonoBehaviour {

	public float Speed = 100f;
	void Update () 
	{
		
		this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * Speed * Time.deltaTime,ForceMode.Impulse);
		Destroy (this.gameObject,3);
		
	}
}
