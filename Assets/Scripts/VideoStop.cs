using System;
using UnityEngine;
using TouchScript.Gestures;

public class VideoStop : MonoBehaviour {

	public VideoSource video;
	
	void Update () {}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if ( this.enabled ) {
				video.Stop ();
			}
		}
	}
}
