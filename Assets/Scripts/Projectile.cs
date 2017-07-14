using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float damage = 25f;
	public float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (Vector3.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (!collider.gameObject.GetComponent<Attackers> ()) {
			return;
		}
	
		Health health = collider.gameObject.GetComponent<Health> ();

		// Handles destruction of the object too
		health.DealDamage (damage);

		Destroy (gameObject);
	}
}
