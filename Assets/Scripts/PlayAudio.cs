using UnityEngine;
using System.Collections;

public class PlayAudio : MonoBehaviour {
	public AudioSource sound;

	private bool canPlay = true;
	void Update () {}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "finger") {
			if (canPlay) {
				canPlay = false;
				sound.Play();
			}
		}
	}

	void OnTriggerExit (Collider other) {
		canPlay = true;
	}
}
