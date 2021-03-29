using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour 
{
	private GuiDisplay guiDisplay;
	public GameObject GuiGameObject;
	void Awake()
	{
		guiDisplay = GuiGameObject.GetComponent<GuiDisplay> ();

	}
	void OnTriggerEnter (Collider other) 
	{	

		if (other.tag == "Finish") 
		{
			guiDisplay.LevelUp();
			if(Application.loadedLevelName == "Level 1")
				Application.LoadLevel("Level 2");
			else if(Application.loadedLevelName == "Level 2")
				Application.LoadLevel("Game Over");	
			
		
		}
		
		
	}


}
