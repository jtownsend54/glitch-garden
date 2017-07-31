using UnityEngine;
using System.Collections;

public class Defenders : MonoBehaviour {
	private StarDisplay starDisplay;

	// Use this for initialization
	void Start () {
		starDisplay = GameObject.FindObjectOfType<StarDisplay> ();
	}
//
//	void OnCollisionEnter2D(Collision2D collision) {
//		Debug.Log (gameObject + " collided with " + collision.gameObject);
//	}

	public void AddStars(int amount) {
		Debug.Log ("Added stars");
		starDisplay.AddStars (amount);
	}
}
