using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public float autoLoadTime;

	void Start() {
		if (autoLoadTime <= 0) {
			return;
		}

		Invoke ("LoadNextLevel", autoLoadTime);
	}

	public void LoadLevel(string name) {
		Debug.Log("Load the level: " + name);
		Application.LoadLevel (name);
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void QuitRequest() {
		Debug.Log("Quit request.");
		Application.Quit();
	}
}