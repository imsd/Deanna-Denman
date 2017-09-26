﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float rotation = Input.GetAxis ("Horizontal") * multiplier;
		Vector3 v3 = new Vector3 (rotation, 0, 0);

		transform.Rotate (v3);
	}
}