using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {
	public const string VOLUME = "volume";
	public const string DIFFICULTY = "difficulty";

	public static void setVolume(float value) {
		PlayerPrefs.SetFloat (VOLUME, value);
	}

//	public static void set(string key, string value) {
//		PlayerPrefs.SetString (key, value);
//	}

	public static void setDifficulty(int value) {
		PlayerPrefs.SetInt (DIFFICULTY, value);
	}

	public static float getVolume() {
		return PlayerPrefs.GetFloat (VOLUME);
	}
	
//	public static string get(string key) {
//		return PlayerPrefs.GetString (key);
//	}
	
	public static int getDifficulty() {
		return PlayerPrefs.GetInt (DIFFICULTY);
	}
}
