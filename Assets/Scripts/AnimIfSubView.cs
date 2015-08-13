using System;
using UnityEngine;
using TouchScript.Gestures;

public class AnimIfSubView : MonoBehaviour {
	public Transform Container;
	public string IfSubView;
	public string AnimName;
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if (GameController.actualSubView == IfSubView) {
				Container.animation.Play (AnimName);
			}
		}
	}
}
