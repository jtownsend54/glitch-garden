using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarDisplay : MonoBehaviour {
	static int availableStars;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddStars(int amount) {
		StarDisplay.availableStars += amount;
		gameObject.GetComponent<Text> ().text = StarDisplay.availableStars.ToString();
	}

	public void UseStars(int amount) {
		StarDisplay.availableStars += amount;
		gameObject.GetComponent<Text> ().text = StarDisplay.availableStars.ToString();
	}
}
