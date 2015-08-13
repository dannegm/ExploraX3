﻿using System;
using UnityEngine;
using TouchScript.Gestures;

public class VideoPause : MonoBehaviour {
	
	public VideoSource video;
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			video.Pause ();
		}
	}

}