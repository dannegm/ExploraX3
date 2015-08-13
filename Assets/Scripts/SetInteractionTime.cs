using UnityEngine;
using System.Collections;

public class SetInteractionTime : MonoBehaviour {
		
	void OnTriggerEnter(Collider other) {
		GameController.lastInteraction = Time.time;
		GameController.canCountTime = true;
	}
}
