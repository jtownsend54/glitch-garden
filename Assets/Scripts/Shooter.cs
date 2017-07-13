using UnityEngine;
using System.Collections;

/**
 * This class has a projectile and shoots (moves) it.
 */
public class Shooter : MonoBehaviour {
	public GameObject projectile;

	private GameObject projectileParent;
		
	// Need to create the projectile parent on start or it may not exist during the fire method. (Video #165).
	void Start () {
		projectileParent = GameObject.Find ("Projectiles");
			
		if (!projectileParent) {
			projectileParent = new GameObject("Projectiles");
		}
	}

	public void Fire() {
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		// Make sure any spawned projectiles go under the Projectiles object
		// Setting the parent of a transform which resides in a prefab is disabled to prevent data corruption.
		newProjectile.transform.parent = projectileParent.gameObject.transform;
		//newProjectile.transform.position
		newProjectile.transform.position = gameObject.transform.Find("Gun").position;


	}
}
