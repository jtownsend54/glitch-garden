using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarDisplay : MonoBehaviour {
	static int availableStars = 200;
	private Text display;
	public enum Status { SUCCESS, FAILURE };

	// Use this for initialization
	void Start () {
		display = gameObject.GetComponent<Text> ();
		display.text = availableStars.ToString ();
	}

	public void AddStars(int amount) {
		StarDisplay.availableStars += amount;
		display.text = StarDisplay.availableStars.ToString();
	}

	public Status UseStars(int amount) {
		if (amount <= availableStars) {
			StarDisplay.availableStars -= amount;
			display.text = StarDisplay.availableStars.ToString ();

			return Status.SUCCESS;
		}

		return Status.FAILURE;
	}
}
