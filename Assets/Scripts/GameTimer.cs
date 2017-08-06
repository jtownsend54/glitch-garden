using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {
	public float LevelTime;
	private float interval = .1f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("MoveTimer", 1f, interval);
	}
	
	// Update is called once per frame
	void MoveTimer () {
		float adjustment = (interval / LevelTime) * 100;
		gameObject.GetComponent<Slider> ().value += adjustment;
	}
}
