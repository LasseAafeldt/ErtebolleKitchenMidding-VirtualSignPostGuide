using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartHunt : MonoBehaviour {

    public Button button;
    CanvasGroup endUI;
	// Use this for initialization
	void Start () {
        endUI = GameObject.Find("EndOfGame").GetComponent<CanvasGroup>();
        button.onClick.AddListener(delegate { click(); });
	}

    // Update is called once per frame
    void click()
    {
        HuntingHandler.tutorial.SetActive(false);
        //HuntingHandler.end.SetActive(false);
        hideEndUI();
        HitDectection.animalDoStuff = false;
        HuntingHandler.pil.SetActive(true);
    }

    void hideEndUI()
    {
        endUI.alpha = 0;
        endUI.interactable = false;
        endUI.blocksRaycasts = false;
    }
}
