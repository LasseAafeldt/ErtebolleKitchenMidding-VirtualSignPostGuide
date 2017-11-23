using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntingHandler : MonoBehaviour {

    public static GameObject tutorial;
    public static GameObject pil;
    CanvasGroup endUI;
    //public static GameObject end;

	void Start () {
        tutorial = GameObject.Find("TutorialOverlay");
        pil = GameObject.Find("pil");
        endUI = GameObject.Find("EndOfGame").GetComponent<CanvasGroup>();

        tutorial.SetActive(true);
        pil.SetActive(true);
        //end.SetActive(false);
        hideInfoUI();
        hideEndUI();
	}
	
    void hideInfoUI()
    {
        GameObject.Find("Canvas").GetComponent<CanvasGroup>().alpha = 0;
        GameObject.Find("Canvas").GetComponent<CanvasGroup>().interactable = false;
        GameObject.Find("Canvas").GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    void hideEndUI()
    {
        endUI.alpha = 0;
        endUI.interactable = false;
        endUI.blocksRaycasts = false;
    }
}
