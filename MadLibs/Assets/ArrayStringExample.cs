﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayStringExample : MonoBehaviour {
	
	public string[] names;
	public string[] places;
	public string[] problems;


	void Start () {
		// loop thru all the names
		//        for (int i = 0; i < names.Length; i++) {
		//            Debug.Log (names [i]);
		//        }

		// draw a random name from the array
		//        int rando = Random.Range(0, names.Length);
		//        Debug.Log (names [rando]);

		// get a random number from 0 to the number of nouns available
		int randNoun = Random.Range(0, names.Length);
		int randPlace = Random.Range(0, places.Length);
		int randProblems = Random.Range(0, problems.Length);



		string line1 = "One time, " + names [randNoun] + " went to " + 
			places[randPlace] +  " to " + problems[randProblems]+ ".";

		// actually print out the madlib
		Debug.Log (line1);


	}

	// Update is called once per frame
	void Update () {

	}
}
