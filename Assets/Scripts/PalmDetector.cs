using UnityEngine;
using System.Collections;

public class PalmDetector : MonoBehaviour {
	
	public Transform Container;
	public string AnimIn;

	private float TimeActual;
	private float TimeToWait = 5f;

	private bool isPalmed = false;
	private bool isHolding = false;

	private bool canUpdateTime = true;

	void Update () {
		if (isPalmed) {
			if (Time.time > (TimeActual + TimeToWait)) {
				isHolding = true;
				canUpdateTime = false;
				TimeActual = Time.time;
			}
		}

		if (isHolding) {
			Container.animation.Play(AnimIn);
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "palm") {
			isPalmed = true;

			if (canUpdateTime) {
				canUpdateTime = false;
				TimeActual = Time.time;
			}
		}
	}
	
	void OnTriggerExit (Collider other) {
		if (other.tag == "palm") {
			isPalmed = false;
			isHolding = false;
			canUpdateTime = true;
		}
	}
}
