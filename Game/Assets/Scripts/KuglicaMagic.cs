using UnityEngine;
using System.Collections;

public class KuglicaMagic : MonoBehaviour {
	
	public float Speed = 100f;
	void Update () 
	{
		
		this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * Speed * Time.deltaTime,ForceMode.Impulse);
		Destroy (this.gameObject,3);

	}
	
	
}
