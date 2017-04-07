using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeInPanel : MonoBehaviour {
	public float time;

	private Image panel;
	private Color currentColor = Color.black;

	// Use this for initialization
	void Start () {
		panel = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad < time) {
			currentColor.a = 1 - (Time.timeSinceLevelLoad / time);
			panel.color = currentColor;
		} else {
			gameObject.SetActive(false);
		}
	}
}
