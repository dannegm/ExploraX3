using UnityEngine;
using System.Collections;

public class AudioPlay : MonoBehaviour {

	public AudioSource AudioRef;

	public bool isAnimate = true;
	public string AnimFadeOut;
	
	private bool canPlay = true;

	void Update () {
		if (!AudioRef.isPlaying) {
			canPlay = true;
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			if ( this.enabled ) {
				if (canPlay) {
					canPlay = false;
					if (isAnimate) animation.Play(AnimFadeOut);
					
					AudioController.StopAll();
					AudioRef.Play();
				}
			}
		}
	}
}
