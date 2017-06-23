using UnityEngine;
using System.Collections;

public class Lizard : MonoBehaviour {
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
		
		animator.SetTrigger("isAttacking");
	}
}
