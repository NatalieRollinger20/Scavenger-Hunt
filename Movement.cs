using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//If D Key is pressed...
		if (Input.GetKey (KeyCode.D)) {
			//Move right
			Vector3 newPosition = new Vector3 (transform.position.x + 0.1f,
				                      transform.position.y, transform.position.z);
			transform.position = newPosition;
		}

		//If D Key is pressed...
		if (Input.GetKey (KeyCode.A)) {
			//Move right
			Vector3 newPosition = new Vector3 (transform.position.x - 0.1f,
				                      transform.position.y, transform.position.z);
			transform.position = newPosition;
		}
		if (Input.GetKey (KeyCode.W)) {
			//Move right
			Vector3 newPosition = new Vector3 (transform.position.x,
				transform.position.y + 0.1f, transform.position.z);
			transform.position = newPosition;
		}
		if (Input.GetKey (KeyCode.S)) {
			//Move right
			Vector3 newPosition = new Vector3 (transform.position.x,
				transform.position.y - 0.1f, transform.position.z);
			transform.position = newPosition;
		}
	}
}
