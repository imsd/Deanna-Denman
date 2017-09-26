using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseStuff : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

		void OnMouseDown() {
			renderer.material.color -= new Color(0.1F, 0, 0) * Time.deltaTime;
	  }
	}
}
