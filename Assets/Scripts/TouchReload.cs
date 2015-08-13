using UnityEngine;
using System.Collections;

public class TouchReload : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			GameController.lastInteraction = Time.time;
			Application.LoadLevel("pool");
		}
	}
}
