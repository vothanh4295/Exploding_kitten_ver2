using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour {

	public void mainmenu() {
		Application.LoadLevel("Main");
	}

	public void startgame() {
		Application.LoadLevel("Startgame");
	}

	public void howtoplay() {
		Application.LoadLevel("Howtoplay");
	}

	public void about() {
		Application.LoadLevel("About");
	}

	public void exit() {
		Application.Quit();
	}
}
