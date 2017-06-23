﻿using UnityEngine;
using System.Collections;

public class Fox : MonoBehaviour {
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
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

		// Will attack anything else
		animator.SetTrigger("isAttacking");
	}
}
