using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {
	const string VOLUME = "volume";
	const string DIFFICULTY = "difficulty";

	public static void set(string key, float value) {
		PlayerPrefs.SetFloat (key, value);
	}

	public static void set(string key, string value) {
		PlayerPrefs.SetString (key, value);
	}

	public static void set(string key, int value) {
		PlayerPrefs.SetInt (key, value);
	}

	public static float get(string key, float value) {
		return PlayerPrefs.GetFloat (key);
	}
	
	public static string get(string key, string value) {
		return PlayerPrefs.GetString (key);
	}
	
	public static int get(string key, int value) {
		return PlayerPrefs.GetInt (key);
	}
}
