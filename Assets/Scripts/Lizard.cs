using UnityEngine;
using System.Collections;

public class Lizard : MonoBehaviour {
	Animator animator;
	Attackers attackerComponent;
	
	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
		attackerComponent = gameObject.GetComponent<Attackers> ();
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
		GameObject target = collider.gameObject;
		
		if (!target.GetComponent<Defenders> ()) {
			return;
		}

		attackerComponent.SetCurrentTarget (target);
		
		// Will attack anything else, change animation to attacking
		animator.SetBool("isAttacking", true);
	}
}
