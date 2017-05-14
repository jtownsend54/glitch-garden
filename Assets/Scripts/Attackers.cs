using UnityEngine;
using System.Collections;

public class Attackers : MonoBehaviour {

	[Range(-1, 1)]
	public float walkSpeed;

	// Use this for initialization
	void Start () {
		Rigidbody2D body = gameObject.AddComponent<Rigidbody2D> ();
		body.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log (gameObject + " collided with " + collider.gameObject);
	}
}
