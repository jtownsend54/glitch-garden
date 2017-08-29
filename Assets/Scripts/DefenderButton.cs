using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DefenderButton : MonoBehaviour {
	public static GameObject defender;
	public GameObject prefab;
	private Text defenderCost;

	private DefenderButton[] buttons;

	// Use this for initialization
	void Start () {
		// Set the button color to black by default
		gameObject.GetComponent<SpriteRenderer> ().color = Color.black;

		// Create an array of buttons so we can loop through them later
		buttons = GameObject.FindObjectsOfType<DefenderButton> ();

		// Get the UI text element from the defender button
		defenderCost = gameObject.GetComponentInChildren<Text> ();

		// Get the star cost from the game prefab
		float cost = prefab.gameObject.GetComponent<Defenders> ().starCost;

		// Set the star cost
		defenderCost.text = cost.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp() {
		defender = prefab;

		foreach (DefenderButton button in buttons) {
			button.GetComponent<SpriteRenderer> ().color = Color.black;
		}

		gameObject.GetComponent<SpriteRenderer> ().color = Color.white;
	}
}
