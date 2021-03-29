using UnityEngine;
using System.Collections;

public class GuiTextFade : MonoBehaviour {
	const float duration = 2.5f;

	void Update () 
	{	
		this.GetComponent<GUIText>().text = "aaa"; 
		if (Time.time > duration) 
		{
			Destroy(gameObject);	
		
		}
		Color newColor = GetComponent<GUIText>().material.color;
		float proportion  = Time.time /duration;
		newColor.a = Mathf.Lerp(1,0,proportion);
		GetComponent<GUIText>().material.color = newColor;
	}
}
