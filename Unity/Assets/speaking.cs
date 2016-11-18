using UnityEngine;
using System.Collections;

public class speaking : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (MonsterFire.saying == true) {
			GetComponent<Animator> ().enabled = true;
		} else {
			GetComponent<Animator> ().enabled = false;
		}
			
	}
}
