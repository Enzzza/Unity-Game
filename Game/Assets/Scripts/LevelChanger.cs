﻿using UnityEngine;
using System.Collections;

public class LevelChanger : MonoBehaviour {
	
	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(Screen.width,10,100,90), "Levels");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(20,40,80,20), "Level 1")) {
			Application.LoadLevel(0);
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(20,70,80,20), "Level 2")) {
			Application.LoadLevel(1);
		}
	}
}