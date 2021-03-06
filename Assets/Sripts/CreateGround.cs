﻿using UnityEngine;
using System.Collections;

public class CreateGround : MonoBehaviour {

	public GameObject[] Ground;
	public bool done = false;
	//public Transform relCamera;

	// Use this for initialization
	void Start () 
	{
		done = false;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (this.transform.position.x < Camera.main.gameObject.transform.position.x + 12 && !done) 
		{
			spawn ();
		}
		if (this.transform.position.x + this.renderer.bounds.size.x < Camera.main.gameObject.transform.position.x - 10) 
		{
			Destroy (this.gameObject);
		}
	}

	void spawn()
	{
		int i = Random.Range (0, Ground.GetLength (0));
		if (i%4 == 3) {
						Instantiate (Ground [i], new Vector3 (this.transform.position.x + (this.renderer.bounds.size.x / 2) + (Ground [i].renderer.bounds.size.x / 2) + 2, this.transform.position.y, 0), Quaternion.identity);
				} else {
						Instantiate (Ground [i], new Vector3 (this.transform.position.x + (this.renderer.bounds.size.x / 2) + (Ground [i].renderer.bounds.size.x / 2), this.transform.position.y, 0), Quaternion.identity);
				}
		done = true;
	}
}
