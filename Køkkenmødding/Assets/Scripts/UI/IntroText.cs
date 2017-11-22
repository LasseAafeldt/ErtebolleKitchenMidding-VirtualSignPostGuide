using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour {
    public Text introtex;
    public Text introHeadline;
    public Button but;
    CanvasGroup canvas;
	// Use this for initialization
	void Start () {
        canvas = gameObject.GetComponent<CanvasGroup>();
        but.onClick.AddListener(delegate { click(); });
	}
	
	// Update is called once per frame
	void Update () {
		if(ChooseLanguage.language == 0)
        {
            introHeadline.text = "Hej og velkommen til appen om Ertebølle køkkenmødding!";

            introtex.text = "For at få mest ud af denne app skal du starte med at vende dig med mobilen ud mod vandet til venstre for skiltene. \n" +
                "For at styre hvad du vil se kan du bevæge dig i en cirkel med mobilen i øjenhøjde. \n" +
                "Rundt om på møddingen er der objekter du kan trykke på og få mere viden om Ertebølle. \n" +
                "\n" +
                "God fornøjelse!";
        }
        if(ChooseLanguage.language == 1)
        {
            introHeadline.text = "Hello and welcome to the app for the Ertebølle kitchen midden!";

            introtex.text = "To get the most out of this app, start by standing facing the ocean with the signs to your right. \n" +
                "To control what you want to look at you have to move around with your phone at eye height. \n" +
                "There are objects you can tap scattered on the midden which will give you information about Ertebølle. \n" +
                "\n" +
                "Enjoy!";
        }
	}
    void click()
    {
        canvas.alpha = 0;
        canvas.interactable = false;
        canvas.ignoreParentGroups = false;
    }
}
