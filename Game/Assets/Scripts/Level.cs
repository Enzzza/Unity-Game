using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
	const float duration = 2.5f;
	public GUIText introText;
	public GameObject GuiDisplayGameObject;
	private GuiDisplay guiDisplay;
	void Awake()
	{
		guiDisplay = GuiDisplayGameObject.GetComponent<GuiDisplay>();
		
	}

	void Update()
	{

		introText.text = "Level " + guiDisplay.GetLevel ().ToString ();
		Color newColor = introText.material.color;
		float proportion  = Time.timeSinceLevelLoad /duration;
		newColor.a = Mathf.Lerp(1,0,proportion);
		introText.material.color = newColor;
	}
}
