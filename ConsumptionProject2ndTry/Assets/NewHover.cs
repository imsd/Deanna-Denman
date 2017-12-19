using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHover : MonoBehaviour {

	public string HoverTxt4;
	public string HoverTxt5;
	public string HoverTxt6;
	public string HoverTxt7;

	public TextMesh DisplayTextObject;

	void Update() {

		if (Time.time > 15f) {
			// switch the 3d text so that its text value
			// is now whatever text value this hover instance holds
			DisplayTextObject.text = HoverTxt4;

			// show it
			DisplayTextObject.color = Color.green;
		}

		if (Time.time > 25f) {
			// switch the 3d text so that its text value
			// is now whatever text value this hover instance holds
			DisplayTextObject.text = HoverTxt5;

			// show it
			DisplayTextObject.color = Color.green;
		}
		if (Time.time > 35f) {
			// switch the 3d text so that its text value
			// is now whatever text value this hover instance holds
			DisplayTextObject.text = HoverTxt6;

			// show it
			DisplayTextObject.color = Color.green;
		}
	
	}

	void OnMouseExit() {
		DisplayTextObject.color = new Color(0,0,0,0);
	}
}