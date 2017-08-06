using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {
	public float LevelTime;

	private float interval = .1f;
	private Slider timer;
	private AudioSource audio;
	private bool isEndOfLevel = false;
	private Text winMessage;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("MoveTimer", 1f, interval);
		timer = gameObject.GetComponent<Slider> ();
		audio = gameObject.GetComponent<AudioSource> ();
		winMessage = GameObject.Find ("Win Message").GetComponent<Text> ();
		winMessage.enabled = false;
	}

	void Update () {
		if (timer.value >= timer.maxValue && !isEndOfLevel) {
			isEndOfLevel = true;

			winMessage.enabled = true;

			audio.Play();

			Invoke("LoadNextLevel", audio.clip.length);
		}
	}
	
	// Update is called once per frame
	void MoveTimer () {
		float adjustment = (interval / LevelTime) * 100;
		timer.value += adjustment;
	}

	void LoadNextLevel() {
		GameObject.FindObjectOfType<LevelManager>().LoadNextLevel();
	}
}
