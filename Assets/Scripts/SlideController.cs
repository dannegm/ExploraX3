using UnityEngine;
using System.Collections;

public class SlideController : MonoBehaviour {

	public Transform[] Slides;

	public string AnimToLeftOut;
	public string AnimToLeftIn;

	public string AnimToRightOut;
	public string AnimToRightIn;

	public int step = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftArrow))
			SlideToLeft();
		else if(Input.GetKeyDown(KeyCode.RightArrow))
			SlideToRight();


		/*
		LeapManager leapManager = LeapManager.Instance;
		if(leapManager.IsGestureSwipeDetected()) {
			if(leapManager.GetSwipeDirection() == LeapManager.SwipeDirection.Left)
				SlideToRight();
			else if(leapManager.GetSwipeDirection() == LeapManager.SwipeDirection.Right)
				SlideToLeft();
		}
		/**/
	}
	
	public void SlideToLeft () {
		if (step > 0) {
			Slides [step].animation.Play (AnimToLeftOut);
			step--;
			Slides [step].animation.Play (AnimToLeftIn);
		}
	}
	
	public void SlideToRight () {
		if (step < (Slides.Length - 1)) {
			Slides [step].animation.Play (AnimToRightOut);
			step++;
			Slides [step].animation.Play (AnimToRightIn);
		}
	}
}
