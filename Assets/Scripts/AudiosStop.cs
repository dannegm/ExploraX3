using UnityEngine;
using System.Collections;

public class AudiosStop : MonoBehaviour {
	void Update () {}
	
	void OnTriggerEnter (Collider other) {
		if (other.tag == "finger") {
			AudioController.StopAll();
		}
	}
}
