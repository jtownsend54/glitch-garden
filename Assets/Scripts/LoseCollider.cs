using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D collider) {
		GameObject.FindObjectOfType<LevelManager> ().LoadLevel ("03 Lose");
	}
}
