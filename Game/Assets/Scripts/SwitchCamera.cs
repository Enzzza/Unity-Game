using UnityEngine;
using System.Collections;

public class SwitchCamera : MonoBehaviour {
	public GameObject []cameras;
	public string []shortcuts;
	void Update () 
	{
		for (int i=0; i<cameras.Length; i++) 
		{
			if(Input.GetKeyUp(shortcuts[i]))
			{
				ChangeCamera(i);

			}
		
		}
	}
	void ChangeCamera(int index)
	{
		for (int i=0; i<cameras.Length; i++) 
		{
			if(i!=index)
			{

				cameras[i].GetComponent<Camera>().enabled = false;
			}
			else
			{

				cameras[i].GetComponent<Camera>().enabled = true;
			}
		}


	}
}
