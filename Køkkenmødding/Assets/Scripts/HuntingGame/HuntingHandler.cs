using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntingHandler : MonoBehaviour {

    public static GameObject tutorial;
	// Use this for initialization
	void Start () {
        tutorial = GameObject.Find("TutorialOverlay");

        tutorial.SetActive(true);
	}
	
	// Update is called once per frame

}
