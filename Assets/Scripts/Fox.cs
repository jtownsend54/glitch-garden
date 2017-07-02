using UnityEngine;
using System.Collections;

public class Fox : MonoBehaviour {
	private Animator animator;
	private Attackers attackerComponent;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
		attackerComponent = GetComponent<Attackers> ();
	}

	void OnTriggerEnter2D(Collider2D collider) {
		GameObject target = collider.gameObject;

		if (!target.GetComponent<Defenders> ()) {
			return;
		}

		// Make the fox jump over the stone
		if (target.GetComponent<Stone> ()) {
			animator.SetTrigger("jumpTrigger");
			return;
		}

		attackerComponent.SetCurrentTarget (target);

		// Will attack anything else, change animation to attacking
		animator.SetBool("isAttacking", true);
	}
}
