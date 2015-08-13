using System;
using UnityEngine;
using TouchScript.Gestures;

public class VideoPlay : MonoBehaviour {

	public VideoSource video;
	
	void Update () {}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if ( this.enabled ) {
				video.Play ();
			}
		}
	}
}
