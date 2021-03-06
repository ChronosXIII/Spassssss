﻿using UnityEngine;
using System.Collections;

public class EnemyFire : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float nextFire;
	private float fireRate;
	// Update is called once per frame
	void Update () {

		if ( Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			audio.Play ();
		}
	}
}
