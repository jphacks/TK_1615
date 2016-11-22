using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class textScript : MonoBehaviour {
	

	public Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void TextField(string message){
		text.text = message;
	}


}
