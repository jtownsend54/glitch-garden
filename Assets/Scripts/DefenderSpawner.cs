using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {
	private GameObject defenderOrganizer;
	private StarDisplay starDisplay;

	// Use this for initialization
	void Start () {
		defenderOrganizer = GameObject.Find ("Defenders");
		starDisplay = GameObject.FindObjectOfType<StarDisplay> ();
		
		if (!defenderOrganizer) {
			defenderOrganizer = new GameObject("Defenders");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		GameObject defenderPrefab = DefenderButton.defender;

		Vector3 position = Input.mousePosition;
		Vector2 placement = CalculateWorldPointOfMouseClick (position);

		// Check for an existing defender already at placements x/y
		foreach (Defenders curDefender in defenderOrganizer.GetComponentsInChildren<Defenders>()) {
			if (curDefender.transform.position.x == placement.x && curDefender.transform.position.y == placement.y) {
				return;
			}
		}

		if (starDisplay.UseStars (defenderPrefab.GetComponent<Defenders> ().starCost) == StarDisplay.Status.FAILURE) {
			Debug.Log("Not enough star power");
			return;
		}

		GameObject defender = Instantiate (defenderPrefab, placement, Quaternion.identity) as GameObject;
		defender.transform.parent = defenderOrganizer.transform;
	}

	Vector2 CalculateWorldPointOfMouseClick(Vector3 position) {
		Vector3 worldPoint = GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint (position);

		return new Vector2(Mathf.Round(worldPoint.x), Mathf.Round(worldPoint.y));
	}
}
