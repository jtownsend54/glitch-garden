using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {
	// Use this for initialization
	void Start () {
		MusicManager manager = GameObject.Find ("MusicManager").GetComponent<MusicManager>() as MusicManager;
		manager.PlayClip (0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad >= 3) {
			LevelManager manager = GameObject.Find ("LevelManager").GetComponent<LevelManager>() as LevelManager;
			manager.LoadNextLevel();
		}
	}
}
