using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	private LevelChanger levelChanger;
	
	void Awake()
	{
		levelChanger = GetComponent<LevelChanger> ();
	}
	void Update () 
	{
	
		if(Input.GetKeyUp(KeyCode.M))
		{
			levelChanger.enabled = !levelChanger.enabled;	
			
		}

	}
}
