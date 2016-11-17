using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class textScript : MonoBehaviour {
	
	public GameObject controller;
	public Text text;

	// Use this for initialization
	void Start () {
		this.transform.position = controller.transform.position;
		this.transform.rotation = controller.transform.rotation;
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = controller.transform.position;
		//text.text = "りんごがゴリラを食べたおうな";

	}
	void TextField(string message){
		text.text = message;
	}


}
