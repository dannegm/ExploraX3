using UnityEngine;
using System.Collections;

public class TouchLock : MonoBehaviour {
	
	
	public Collider[] colliders;
	
	void Update () {}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "finger") {
			if (this.enabled) {
				foreach (Collider col in colliders) {
					col.enabled = false;
					this.enabled = false;
				}
			}
		}
	}
}
