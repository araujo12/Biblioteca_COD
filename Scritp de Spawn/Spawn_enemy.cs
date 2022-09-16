using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject ship;
	public float interval = 1;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("NextShip", interval, interval);
	}

	void NextShip() {
		Instantiate (ship, transform.position, Quaternion.identity);
	}
}
