﻿using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	public float health = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DealDamage(float damage) {
		health -= damage;

		if (health <= damage) {
			DestroyDefender();
		}
	}

	public void DestroyDefender() {
		Destroy (gameObject);
	}
}
