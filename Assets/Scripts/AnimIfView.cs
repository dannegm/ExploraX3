using System;
using UnityEngine;
using TouchScript.Gestures;

public class AnimIfView : MonoBehaviour {
	public Transform Container;
	public string IfView;
	public string AnimName;

	void Update () {}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if ( this.enabled ) {
				if (GameController.actualView == IfView) {
					Container.animation.Play (AnimName);
				}
			}
		}
	}
}
