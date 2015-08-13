using System;
using UnityEngine;
using TouchScript.Gestures;

public class AnimMultipleIfView : MonoBehaviour {
	public Transform[] Container;
	public string IfView;
	public string AnimName;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if (GameController.actualView == IfView) {
				foreach (Transform c in Container) {
					c.animation.Play (AnimName);
				}
			}
		}
	}
}
