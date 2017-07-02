using UnityEngine;
using System.Collections;

/**
 * This class has a projectile and shoots (moves) it.
 */
public class Shooter : MonoBehaviour {
	public GameObject projectile;
	public GameObject projectileParent;

	public void Fire() {
		GameObject newProjectile = Instantiate (projectile) as GameObject;
		newProjectile.transform.position = gameObject.transform.Find("Gun").position;

		// Make sure any spawned projectiles go under the Projectiles object
		newProjectile.transform.SetParent (projectileParent.transform);
	}
}
