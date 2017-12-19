using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverText : MonoBehaviour {

	public string HoverTxt1;
	public string HoverTxt2;
	public string HoverTxt3;
	public TextMesh DisplayTextObject;

	void Update() {

		if (Time.time > 10f) {
			// switch the 3d text so that its text value
			// is now whatever text value this hover instance holds
			DisplayTextObject.text = HoverTxt1;

			// show it
			DisplayTextObject.color = Color.white;
		}

		if (Time.time > 20f) {
			// switch the 3d text so that its text value
			// is now whatever text value this hover instance holds
			DisplayTextObject.text = HoverTxt2;

			// show it
			DisplayTextObject.color = Color.white;
		}
		if (Time.time > 30f) {
			// switch the 3d text so that its text value
			// is now whatever text value this hover instance holds
			DisplayTextObject.text = HoverTxt3;

			// show it
			DisplayTextObject.color = Color.white;
		}

	}

	void OnMouseExit() {
		DisplayTextObject.color = new Color(0,0,0,0);
	}
}