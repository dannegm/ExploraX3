﻿using System;
using UnityEngine;
using TouchScript.Gestures;

public class AnimIfNoSubView : MonoBehaviour {
	public Transform Container;
	public string IfSubView;
	public string AnimName;
	
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		if (GameController.actualSubView != IfSubView) {
			Container.animation.Play (AnimName);
		}
	}
}
