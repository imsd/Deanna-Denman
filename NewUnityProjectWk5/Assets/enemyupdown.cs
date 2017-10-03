using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyupdown : MonoBehaviour {



		private bool dirForward = true;
		public float speed = 2.0f;
		void Start () {

			InvokeRepeating("ChangeDirection", 0, 2);
		}
		void Update () {
			if (dirForward)
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
			else
			transform.Translate (Vector3.forward * -1 * speed * Time.deltaTime);


		} 
		void ChangeDirection() {

			dirForward = !dirForward;

		}
	}