using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class OptionsController : MonoBehaviour {
	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;

	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		musicManager 			= GameObject.FindObjectOfType<MusicManager> ();
		volumeSlider.value 		= PlayerPrefsManager.getVolume();
		difficultySlider.value 	= PlayerPrefsManager.getDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.ChangeVolume (volumeSlider.value);
	}

	public void savePrefs() {
		PlayerPrefsManager.setVolume(volumeSlider.value);
		PlayerPrefsManager.setDifficulty((int) difficultySlider.value);
		levelManager.LoadLevel ("01 Start");
	}

	public void SetDefaults() {
		volumeSlider.value = 0.5f;
		difficultySlider.value = 2f;
	}
}
