using UnityEngine;
using System.Collections;

public class KeyPress : MonoBehaviour {
	public string Value;
	private bool canPress = true;
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if (canPress) {
				canPress = false;
				GameController.key_pressed += Value;
				GameController.time_pressed = Time.time;
			}
		}
	}
	
	void OnTriggerExit (Collider other) {
		if (other.tag == "finger") {
			canPress = true;
		}
	}
}
