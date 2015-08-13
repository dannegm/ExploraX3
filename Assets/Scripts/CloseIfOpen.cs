using UnityEngine;
using System.Collections;

public class CloseIfOpen : MonoBehaviour {

	public MenuHover[] menus;
	public string AnimOut;
	
	public Transform Overlive;
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "finger") {
			//
			foreach (MenuHover menu in menus) {
				Transform container = menu.Menu;
				if (menu.opened) {
					container.animation.Play(AnimOut);
					menu.opened = false;
					Overlive.animation.Play("desatenue");
				}
			}
		}
	}
}
