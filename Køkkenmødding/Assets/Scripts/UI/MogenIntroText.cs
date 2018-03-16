using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MogenIntroText : MonoBehaviour {
    public Text tex;
    public Button but;
    public DisableOptions disOption;
    public GameObject optionsCanvasObj;
    CanvasGroup canvas;
	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("MogensIntro").GetComponent<CanvasGroup>();
        but.onClick.AddListener(delegate { click(); });
	}
	
	// Update is called once per frame
	void Update () {
		if(ChooseLanguage.language == 0)
        {
            tex.text = "Goddag! Jeg er en stenaldermand, og jeg findes rundt omkring i app’en. Hvis du trykker på mig, vil jeg fortælle dig noget om det, der bliver vist på skærmen.";
        }
        if(ChooseLanguage.language == 1)
        {
            tex.text = "Hello! I'm a Stoneage man and you can find me places in the app. If you want to hear what i have to say about whatever is on the screen you can press me";
        }
	}

    void click()
    {
        canvas.alpha = 0;
        canvas.interactable = false;
        canvas.blocksRaycasts = false;
        if (!SystemInfo.supportsGyroscope)
        {
            HierarchyHandler.gyroCanvas.SetActive(true);
            if (optionsCanvasObj.activeInHierarchy == true)
            {
                disOption.disable();
            }
        }else
        {
            disOption.enable();
        }
    }
}
