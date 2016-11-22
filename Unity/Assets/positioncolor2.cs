using UnityEngine;
using System.Collections;

public class positioncolor2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = this.transform.position;
		if (pos.z < -2) {
			this.transform.localScale = new Vector3 (0.3f, 0.3f, 0.3f);
		} else {
			this.transform.localScale = new Vector3 (0.001f, 0.001f, 0.001f);
		}
	}
}
