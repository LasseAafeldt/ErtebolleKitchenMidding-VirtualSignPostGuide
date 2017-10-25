using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntingHandler : MonoBehaviour {

    public static GameObject tutorial;
    public static GameObject pil;
	// Use this for initialization
	void Start () {
        tutorial = GameObject.Find("TutorialOverlay");
        pil = GameObject.Find("pil");

        tutorial.SetActive(true);
        pil.SetActive(true);
	}
	
	// Update is called once per frame

}
