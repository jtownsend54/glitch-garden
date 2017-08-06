using UnityEngine;
using System.Collections;

public class Defenders : MonoBehaviour {
	private StarDisplay starDisplay;
	public int starCost = 100;

	// Use this for initialization
	void Start () {
		starDisplay = GameObject.FindObjectOfType<StarDisplay> ();
	}

	public void AddStars(int amount) {
		Debug.Log ("Added stars");
		starDisplay.AddStars (amount);
	}
}
