using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	[HideInInspector]
	public bool isPaused;

	[SerializeField]
	private KeyCode pauseButton;
	[SerializeField]
	private GameObject panelPause;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(pauseButton)) {
			isPaused = !isPaused;
		}

		if (isPaused) {
			panelPause.SetActive (true);
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			Time.timeScale = 0;
		} else {
			panelPause.SetActive (false);
			Time.timeScale = 1;
		}
	}
}
