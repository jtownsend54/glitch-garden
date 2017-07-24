using UnityEngine;
using System.Collections;

public class AttackerSpawner : MonoBehaviour {
	public GameObject[] attackers;
	private GameObject attackerOrganizer;

	// Use this for initialization
	void Start () {
		attackerOrganizer = GameObject.Find ("Attackers");
		
		if (!attackerOrganizer) {
			attackerOrganizer = new GameObject("Attackers");
		}
	}
	
	// Update is called once per frame
	void Update () {
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


		float threshold = spawnsPerSecond * Time.deltaTime / 5;


		if (Random.value < threshold) {
			return true;
		}

		return false;
	}
}
