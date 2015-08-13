using UnityEngine;
using System.Collections;

public class LM_hover : MonoBehaviour {

	public Transform Element;
	public Vector3 HoverPosition;

	private Vector3 originalPosition;

	// Use this for initialization
	void Start () {
		originalPosition = Element.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			Element.localPosition = HoverPosition;
		}
	}
	
	void OnTriggerExit(Collider other) {
		if (other.tag == "finger") {
			Element.localPosition = originalPosition;
		}
	}
}
