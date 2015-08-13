using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	
	/*
	 * Statics methods
	 */

	public static bool debugMode = false;
	public static string actualView = "none";
	public static string actualSubView = "none";
	public static float lastInteraction;
	public static bool canCountTime = false;
	
	public static string key_pressed;
	public static float time_pressed;
	
	/*
	 * Instaced methods
	 */
	
	// Delegate vars	
	public bool _DebugMode = false;
	public string _keyPressed;
	public string _ActualView;
	
	public string PasswordToRebot;
	public string PasswordToExit;
	
	private float TimeActual;
	private float TimeStep = 1f;

	private bool canAtenue = true;

	public float timeToReload;
	public float _LastInteraction;

	// Objects
	public Transform black;
	
	void Awake () {
		actualView = "none";
		TimeActual = Time.time;
	}

	void Update () {
		_LastInteraction = lastInteraction;

		if (canCountTime) TimeActual = Time.time;

		debugMode = _DebugMode;
		_ActualView = actualView;
		_keyPressed = key_pressed;

		float secondsLeft = (lastInteraction + timeToReload) - TimeActual;
		float is20timeleft = timeToReload * 0.60f;
		float secondsLeftAtenuate = (lastInteraction + is20timeleft) - TimeActual;
		
		if (TimeActual - time_pressed > TimeStep) {
			key_pressed = "";
		}

		
		if (TimeActual > (lastInteraction + is20timeleft) && canAtenue) {
			canAtenue = false;
			black.animation.Play("atenue");
		}
		if (TimeActual < (lastInteraction + is20timeleft)) {
			black.GetComponent<AnimAlpha>().Alpha = 0;
			canAtenue = true;
		}

		if (TimeActual > (lastInteraction + timeToReload)) {
			lastInteraction = TimeActual;
			Application.LoadLevel("pool");
		}
		
		if (key_pressed == PasswordToRebot) {
			lastInteraction = TimeActual;
			Application.LoadLevel("pool");
		}
		
		if (key_pressed == PasswordToExit) {
			lastInteraction = TimeActual;
			Application.Quit();
		}
	}
}
