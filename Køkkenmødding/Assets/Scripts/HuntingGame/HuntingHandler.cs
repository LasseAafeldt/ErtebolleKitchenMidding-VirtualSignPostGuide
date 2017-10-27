using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntingHandler : MonoBehaviour {

    public static GameObject tutorial;
    public static GameObject pil;
    public static GameObject end;
	// Use this for initialization
	void Start () {
        tutorial = GameObject.Find("TutorialOverlay");
        pil = GameObject.Find("pil");
        end = GameObject.Find("EndOfGame");

        tutorial.SetActive(true);
        pil.SetActive(true);
        end.SetActive(false);
	}
	
	// Update is called once per frame

}
