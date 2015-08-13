using System;
using UnityEngine;
using TouchScript.Gestures;

public class SetSubView : MonoBehaviour {
	public string SubViewName;
	
	private bool canSetSubView = false;
	void Update () {
		if (canSetSubView) {
			GameController.actualSubView = SubViewName;
			canSetSubView = false;
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			canSetSubView = true;
		}
	}
}
