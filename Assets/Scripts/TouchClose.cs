using UnityEngine;
using System.Collections;

public class TouchClose : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			GameController.lastInteraction = Time.time;
			Application.Quit();
		}
	}
}
