using UnityEngine;
using System.Collections;

public class DefenderButton : MonoBehaviour {
	public static GameObject defender;
	public GameObject prefab;

	private DefenderButton[] buttons;

	// Use this for initialization
	void Start () {
		// Set the button color to black by default
		gameObject.GetComponent<SpriteRenderer> ().color = Color.black;

		// Create an array of buttons so we can loop through them later
		buttons = GameObject.FindObjectsOfType<DefenderButton> ();
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
