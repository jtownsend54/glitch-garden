using UnityEngine;
using System.Collections;

public class Fox : MonoBehaviour {
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider) {
		GameObject target = collider.gameObject;

		if (!target.GetComponent<Defenders> ()) {
			return;
		}

		if (target.GetComponent<Stone> ()) {
			animator.SetTrigger("jumpTrigger");
		}
	}
}
