using UnityEngine;
using System.Collections;
using System;

public class AttackerSpawner : MonoBehaviour {
	public GameObject[] attackers;
	private GameObject attackerOrganizer;
	public float startDelay;
	public static bool allowSpawn;
	public GameTimer timer;
	private float levelTime;

	// Use this for initialization
	void Start () {
		attackerOrganizer = GameObject.Find ("Attackers");
		
		if (!attackerOrganizer) {
			attackerOrganizer = new GameObject("Attackers");
		}

		timer = GameObject.FindObjectOfType<GameTimer>();

		allowSpawn = true;
		startDelay = timer.startDelay;
	}
	
	// Update is called once per frame
	void Update () {
		// Delay loading enemies until startDelay has elapsed
		if (Time.timeSinceLevelLoad < startDelay || !allowSpawn) {
			return;
		}

		foreach (GameObject thisAttacker in attackers) {
			if (isTimeToSpawn(thisAttacker)) {
				Spawn(thisAttacker);
			}
		}
	}

	void Spawn(GameObject attacker) {
		GameObject instance = Instantiate (attacker) as GameObject;

		instance.transform.parent = transform;
		instance.transform.position = transform.position;
	}

	bool isTimeToSpawn(GameObject attackerGameObject) {
		Attackers attacker = attackerGameObject.GetComponent<Attackers> ();

		// Attacker should spawn roughing every spawnDelay seconds
		float spawnDelay = attacker.spawnRate;

		// Change this into a percentage. So for a 10 second spawn, this will be 1/10 or .1
		float spawnsPerSecond = 1 / spawnDelay;

		// If the time it took to do a frame is greater than our spawn delay, it took too long
		// and could not spawn.
		if (Time.deltaTime > spawnDelay) {
			Debug.LogWarning("Frame rate is too fast to spawn attacker");
		}

		double chance = ((Math.Pow (1.03, System.Convert.ToDouble (Time.timeSinceLevelLoad))) / 1000 * spawnsPerSecond) + .00001;
		float random = UnityEngine.Random.value;

		return random < chance;
	}

	public static int attackersLeft() {
		return GameObject.FindObjectsOfType<Attackers> ().Length;
	}
}
