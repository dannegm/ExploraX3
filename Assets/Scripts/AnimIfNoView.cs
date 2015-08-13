using System;
using UnityEngine;
using TouchScript.Gestures;

public class AnimIfNoView : MonoBehaviour {
	public Transform Container;
	public string IfView;
	public string AnimName;
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if (GameController.actualView != IfView) {
				Container.animation.Play (AnimName);
			}
		}
	}
}
