using UnityEngine;
using System.Collections;

public class SetView : MonoBehaviour {
	public string ViewName;
	
	private bool canSetView = false;
	void Update () {
		if (canSetView) {
			GameController.actualView = ViewName;
			canSetView = false;
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger" && canSetView == false) {
			canSetView = true;
		}
	}
}
