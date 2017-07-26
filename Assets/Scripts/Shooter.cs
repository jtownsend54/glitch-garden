using UnityEngine;
using System.Collections;

/**
 * This class has a projectile and shoots (moves) it.
 */
public class Shooter : MonoBehaviour {
	public GameObject projectile;

	private GameObject projectileParent;
	private Animator animator;
	private AttackerSpawner laneSpawner;
		
	// Need to create the projectile parent on start or it may not exist during the fire method. (Video #165).
	void Start () {
		projectileParent = GameObject.Find ("Projectiles");
			
		if (!projectileParent) {
			projectileParent = new GameObject("Projectiles");
		}

		animator = gameObject.GetComponent<Animator> ();
		setLaneSpawner ();
	}

	void Update(){
		animator.SetBool("isAttacking", hasAttackerInLane());
	}

	public void Fire() {
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		// Make sure any spawned projectiles go under the Projectiles object
		newProjectile.transform.parent = projectileParent.gameObject.transform;
		newProjectile.transform.position = gameObject.transform.Find("Gun").position;
	}

	bool hasAttackerInLane() {
		if (laneSpawner.transform.childCount <= 0) {
			Debug.LogError("No Spawner Set");
			return false;
		}

		foreach (Transform attacker in laneSpawner.transform) {
			if (attacker.position.x > gameObject.transform.position.x) {
				return true;
			}
		}

		return false;
	}

	void setLaneSpawner() {
		GameObject spawnerParent = GameObject.Find ("Spawners");

		foreach (AttackerSpawner spawner in spawnerParent.GetComponentsInChildren<AttackerSpawner>()) {
			if (spawner.transform.position.y == gameObject.transform.position.y) {
				laneSpawner = spawner;
				break;
			}
		}
	}
}
