using UnityEngine;
using System.Collections;

public class ChangeSlide : MonoBehaviour {

	public SlideController slider;
	public string Direction;

	private bool canSlide = true;

	void Update () {
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if (canSlide) {
				canSlide = false;
				if (Direction == "RTL") {
					Debug.Log ("Slide to Left");
					slider.SlideToLeft();
				}
				if (Direction == "LTR") {
					Debug.Log ("Slide to Right");
					slider.SlideToRight();
				}
			}
		}
	}
	void OnTriggerExit (Collider other) {
		canSlide = true;
	}
}
