using UnityEngine;
using System.Collections;

public class speakingbubble : MonoBehaviour {

	private ParticleSystem particle;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		particle = this.GetComponent<ParticleSystem> ();

		if (MonsterFire.saying == true) {
			particle.Play ();
		} else {
			particle.Stop ();
		}
	
	}
}
