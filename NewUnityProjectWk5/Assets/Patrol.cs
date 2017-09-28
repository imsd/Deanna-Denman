using UnityEngine;
using System.Collections;

	public class Patrol : MonoBehaviour  {

		private bool dirRight = true;
		public float speed = 2.0f;
	void Start () {

		InvokeRepeating("ChangeDirection", 0, 2);
	}
		void Update () {
		if (dirRight)
			transform.Translate (Vector3.right * speed * Time.deltaTime);
		else
			transform.Translate (Vector3.right * -1 * speed * Time.deltaTime);

	
	} 
	void ChangeDirection() {
		
		dirRight = !dirRight;

	}
}
