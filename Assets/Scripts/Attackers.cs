using UnityEngine;
using System.Collections;

public class Attackers : MonoBehaviour {

	[Range(-1, 1)]
	public float walkSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkSpeed * Time.deltaTime);
	}
}
