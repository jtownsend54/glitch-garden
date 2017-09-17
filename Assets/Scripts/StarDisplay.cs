using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarDisplay : MonoBehaviour {
	int startingStars = 50;
	static int availableStars;
	private Text display;
	public enum Status { SUCCESS, FAILURE };

	// Use this for initialization
	void Start () {
		Debug.Log (startingStars);
		display 		= gameObject.GetComponent<Text> ();
		display.text 	= startingStars.ToString ();
		availableStars 	= startingStars;
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
