using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour {

	public GameObject explosion; // drag your explosion prefab here

	void OnCollisionEnter(){
		GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
		Destroy(gameObject); // destroy the box
		Destroy(expl, 3); // delete the explosion after 3 seconds
	// Use this for initialization



		}
	}
	
	// Update is called once per frame

		
	
