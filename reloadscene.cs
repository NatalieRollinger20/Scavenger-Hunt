using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloadscene : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D coll){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
