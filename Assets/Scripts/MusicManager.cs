using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	public AudioClip[] levelClips;
	private AudioSource source;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (gameObject);
	}

	void Start() {
		//Debug.Log (Application.loadedLevel);
		//AudioClip levelClip = levelClips [Application.loadedLevel];
		source = GetComponent<AudioSource>();
	}

	void OnLevelWasLoaded(int level) {
		PlayClip (level);
	}

	public void PlayClip(int level) {
		Debug.Log ("Level: " + level);
		if (!levelClips [level]) {
			return;
		}

		source.clip = levelClips [level];
		// Do not loop on the splash screen
		source.loop = (level > 0);
		source.Play ();
	}

	public void ChangeVolume(float volume) {
		source.volume = volume;
	}

	// Update is called once per frame
//	void Update () {
//	
//	}
}
