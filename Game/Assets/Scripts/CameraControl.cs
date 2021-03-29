using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public GameObject player;
	private Vector3 offset;
	// Update is called once per frame
	void Start(){
		offset = transform.position;
	
	
	}
	void LateUpdate () {
		transform.position = player.transform.position + offset;

	
	
	}
}
