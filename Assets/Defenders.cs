using UnityEngine;
using System.Collections;

public class Defenders : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody2D body = gameObject.AddComponent<Rigidbody2D> ();
		body.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log (gameObject + " collided with " + collision.gameObject);
	}
}
