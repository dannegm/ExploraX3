using System;
using UnityEngine;
using TouchScript.Gestures;

public class AnimMultipleIfSubView : MonoBehaviour {
	public Transform[] Container;
	public string IfSubView;
	public string AnimName;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if (GameController.actualSubView == IfSubView) {
				foreach (Transform c in Container) {
					c.animation.Play (AnimName);
				}
			}
		}
	}
}
