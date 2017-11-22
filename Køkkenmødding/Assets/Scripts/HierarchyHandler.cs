using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HierarchyHandler : MonoBehaviour {

    // Use this for initialization
    public static GameObject optionsCanvas;
    //public static GameObject cookingFacts;
    public static GameObject closeoverlay;
    public static GameObject mute;
    public static GameObject speaker;
	void Start () {
        optionsCanvas = GameObject.Find("OptionsCanvas");
        //cookingFacts = GameObject.Find("CookingFacts");
        closeoverlay = GameObject.Find("CloseOverlay");

        mute = GameObject.Find("MuteIcon");
        speaker = GameObject.Find("SpeakerIcon");

        optionsCanvas.SetActive(false);
        //cookingFacts.SetActive(false);
        closeoverlay.SetActive(false);
        //Debug.Log("i have run");     
	}
	
	// Update is called once per frame
	
}
