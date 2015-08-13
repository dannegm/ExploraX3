using UnityEngine;
using System.Collections;

public class MenuHide : MonoBehaviour {

	public Transform Menu;
	public string AnimOut;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			Menu.animation.Play(AnimOut);
		}
	}
}
