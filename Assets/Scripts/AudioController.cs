using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {


	public AudioSource[] _Audios;
	public static AudioSource[] Audios;

	void Awake () {
		Audios = _Audios;
	}

	public static void StopAll () {
		foreach (AudioSource auudio in Audios) {
			auudio.Stop();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
