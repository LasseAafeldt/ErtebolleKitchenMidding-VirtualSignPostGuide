using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HierarchyHandler : MonoBehaviour {

    // Use this for initialization
    //public static GameObject optionsCanvas;
    //public static GameObject cookingFacts;
    //public static GameObject closeoverlay;
    public static GameObject mute;
    public static GameObject speaker;
    public static GameObject gyroCanvas;
    public static bool camConfig = false;
    public GameObject camConfigCanvas;
    public CanvasGroup optionsCanvasGrp;
	void Start () {
        //optionsCanvas = GameObject.Find("OptionsCanvas");
        //cookingFacts = GameObject.Find("CookingFacts");
        //closeoverlay = GameObject.Find("CloseOverlay");

        mute = GameObject.Find("MuteIcon");
        speaker = GameObject.Find("SpeakerIcon");

        gyroCanvas = GameObject.Find("GyroNotEnabled");
        gyroCanvas.SetActive(false);
        //optionsCanvas.SetActive(false);
        //cookingFacts.SetActive(false);
        //closeoverlay.SetActive(false);
        camConfig = false;
        //optionsCanvasGrp = GameObject.Find("ScreenSpace").GetComponent<CanvasGroup>();
        //Debug.Log("i have run");     
	}
	
    public void CamConfig()
    {
        camConfig = !camConfig;
        //Debug.Log("cam config = " + camConfig);
        if (camConfig)
        {
            camConfigCanvas.SetActive(true);
            optionsCanvasGrp.alpha = 0;
            optionsCanvasGrp.interactable = false;
            optionsCanvasGrp.blocksRaycasts = false;
        }
        else
        {
            camConfigCanvas.SetActive(false);
            optionsCanvasGrp.alpha = 1;
            optionsCanvasGrp.interactable = true;
            optionsCanvasGrp.blocksRaycasts = true;
        }
    }
}
