using UnityEngine;
using System.Collections;

public class TouchTimeActive : MonoBehaviour {

	
	public Collider[] colliders;
	public float TimeWaiting = 5f;

	private float TimeClicked;
	private bool canEnabled = false;
	
	void Update () {
		if (canEnabled) {
			if (Time.time > (TimeClicked + TimeWaiting)) {
				foreach (Collider col in colliders) {
					col.enabled = true;
				}
				canEnabled = false;
				this.enabled = false;
			}
		}
	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "finger") {
			if (this.enabled) {
				TimeClicked = Time.time;
				canEnabled = true;
			}
		}
	}
}
