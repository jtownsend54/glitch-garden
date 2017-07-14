using UnityEngine;
using System.Collections;

public class Attackers : MonoBehaviour {

	[Range(-1, 1)]
	public float walkSpeed;

	public Animator animator;

	private GameObject currentTarget, projectile;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkSpeed * Time.deltaTime);

		if (!currentTarget) {
			animator.SetBool("isAttacking", false);
		}
	}

	void SetWalkSpeed(float speed) {
		walkSpeed = speed;
	}

	void StrikeCurrentTarget(float damage) {
		if (currentTarget && currentTarget.GetComponent<Health>()) {
			currentTarget.GetComponent<Health>().DealDamage(damage);
		}
	}

	public void SetCurrentTarget (GameObject defender) {
		currentTarget = defender;
	}
}
