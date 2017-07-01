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

	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log (collision.gameObject);
		Health health = collision.gameObject.GetComponent<Health> ();

		health.DealDamage (damage);

		// Destroy the attacker
		if (health.health <= damage) {
			Destroy(collision.gameObject);
		}
	}
}
