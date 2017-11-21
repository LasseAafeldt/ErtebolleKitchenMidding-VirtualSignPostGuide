using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Logging : MonoBehaviour {
	/*
	 * Amount of audio played
	 * Amount of time app is open
	 * Time spent on game
	 * all touch related events and where they are touching
	 */
	// Use this for initialization
	private float gameOn = 0.0f;

	void Start () {
		gameOn = Time.time;
		//Time.timeSinceLevelLoad();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
