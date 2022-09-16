using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemy : MonoBehaviour {

	public float interval = 2;

	public GameObject bulletPrefab;
	public GameObject bulletPosion;

	void Start () {
		InvokeRepeating ("Fire", interval, interval);
	}
	
	void Fire() {
		Instantiate (bulletPrefab, bulletPosion.transform.position, Quaternion.identity);
	}
}
