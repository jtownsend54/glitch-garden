using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {
	public float LevelTime;

	private float interval = .1f;
	private Slider timer;
	private AudioSource audio;
	private Text winMessage;
	public float startDelay = 10f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("MoveTimer", startDelay, interval);
		timer = gameObject.GetComponent<Slider> ();
		audio = gameObject.GetComponent<AudioSource> ();
		winMessage = GameObject.Find ("Win Message").GetComponent<Text> ();
		winMessage.enabled = false;
	}

	void Update () {
		if (timer.value >= timer.maxValue && AttackerSpawner.allowSpawn) {
			AttackerSpawner.allowSpawn = false;
		}

		// If spawning has stopped (timer ended) and there are no attackers, move
		// to the next level
		if (!AttackerSpawner.allowSpawn && AttackerSpawner.attackersLeft() == 0) {
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
