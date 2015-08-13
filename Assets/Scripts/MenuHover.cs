using UnityEngine;
using System.Collections;

public class MenuHover : MonoBehaviour {

	public Transform Menu;
	public string AnimIn;
	public string AnimOut;

	public Transform Overlive;

	public float TimeToClose = 5f;

	public bool opened = false;

	private float TimeActual = 0;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (opened) {
			if (Time.time > (TimeActual + TimeToClose)) {
				TimeActual = Time.time;
				Menu.animation.Play(AnimOut);
				Overlive.animation.Play("desatenue");
				opened = false;
			}
		}
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			Menu.animation.Play(AnimIn);
			Overlive.animation.Play("atenue");
			opened = true;
		}
	}

	/*
	void OnTriggerExit(Collider other) {
		if (other.tag == "finger") {
			Menu.animation.Play(AnimOut);
		}
	}
	*/

}
