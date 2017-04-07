using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {
	// Use this for initialization
	void Start () {
		MusicManager manager = GameObject.Find ("MusicManager").GetComponent<MusicManager>() as MusicManager;
		manager.PlayClip (0);
	}
}
