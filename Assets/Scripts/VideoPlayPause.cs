using System;
using UnityEngine;
using TouchScript.Gestures;

public class VideoPlayPause : MonoBehaviour {
	
	public VideoSource video;
	private bool isPlay = false;
	
	public Texture PlayNormal;
	public Texture PlayPress;
	public Texture PauseNormal;
	public Texture PausePress;
	
	private void OnEnable() {
		transform.GetComponent<TapGesture>().Tapped += HandleTapped;
		transform.GetComponent<PressGesture>().Pressed += HandlePressed;
		transform.GetComponent<ReleaseGesture>().Released += HandleReleased;
	}
	
	private void OnDisable() {
		transform.GetComponent<TapGesture>().Tapped -= HandleTapped;
		transform.GetComponent<PressGesture>().Pressed -= HandlePressed;
		transform.GetComponent<ReleaseGesture>().Released -= HandleReleased;
	}
	
	void HandleTapped (object sender, EventArgs e) {
		if (!isPlay) {
			video.Play();
		} else {
			video.Pause();
		}
		isPlay = !isPlay;
	}
	
	void HandleReleased (object sender, EventArgs e) {
		if (!isPlay) {
			transform.renderer.material.mainTexture = PlayNormal;
		} else {
			transform.renderer.material.mainTexture = PauseNormal;
		}
	}
	
	void HandlePressed (object sender, EventArgs e) {
		if (!isPlay) {
			transform.renderer.material.mainTexture = PausePress;
		} else {
			transform.renderer.material.mainTexture = PlayPress;
		}
	}
}
