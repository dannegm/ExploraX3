using UnityEngine;
using System.Collections;

public class AudioHover : MonoBehaviour {

	public Transform PlayButton;
	public string AnimIn;
	public string AnimOut;

	private bool canIn = true;
	private bool canOut = false;
	
	public float TimeToClose = 5f;
	private float TimeActual = 0;

	void Awake () {
		TimeActual = Time.time;
	}

	void Update () {
		if (canOut) {
			if (Time.time > (TimeActual + TimeToClose)) {
				TimeActual = Time.time;
				canIn = true;
				canOut = false;
				PlayButton.animation.Play (AnimOut);
				Debug.Log("Close");
			}
		}
	}
	
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if (canIn) {
				canIn = false;
				PlayButton.animation.Play(AnimIn);
			}
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.tag == "finger") {
			canOut = true;
		}
	}
}
