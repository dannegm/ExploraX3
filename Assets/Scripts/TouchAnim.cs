using UnityEngine;
using System.Collections;

public class TouchAnim : MonoBehaviour {

	public Transform Container;
	public string AnimIn;
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			Container.animation.Play(AnimIn);
		}
	}
}
