﻿using UnityEngine;
using System.Collections;

public class destroyableActor : MonoBehaviour {

	public int health =10;

	public void doDmg(int dmg){
		health -= dmg;
		if (health <= 0) {
			Destroy(this.gameObject);
				}
		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
