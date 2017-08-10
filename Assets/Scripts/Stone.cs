using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {

	void OnTriggerStay2D(Collider2D collider) {
		if (!collider.gameObject.GetComponent<Attackers> ()) {
			return;
		}

		gameObject.GetComponent<Animator> ().SetTrigger ("underAttackTrigger");
	}
}
