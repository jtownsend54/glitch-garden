using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {
	private GameObject defenderOrganizer;

	// Use this for initialization
	void Start () {
		defenderOrganizer = GameObject.Find ("Defenders");
		
		if (!defenderOrganizer) {
			defenderOrganizer = new GameObject("Defenders");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Vector3 position = Input.mousePosition;
		GameObject defender = Instantiate (DefenderButton.defender, CalculateWorldPointOfMouseClick (position), Quaternion.identity) as GameObject;
		defender.transform.parent = defenderOrganizer.transform;
	}

	Vector2 CalculateWorldPointOfMouseClick(Vector3 position) {
		Vector3 worldPoint = GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint (position);

		return new Vector2(Mathf.Round(worldPoint.x), Mathf.Round(worldPoint.y));
	}
}
