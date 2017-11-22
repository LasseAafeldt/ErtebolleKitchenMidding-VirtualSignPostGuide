using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour {
    public Button but;
    public Text tex;
    CanvasGroup canvas;
	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("EndOfGame").GetComponent<CanvasGroup>();
        if(ChooseLanguage.language == 0)//Danish
        {
            tex.text = "Spil igen!";
        }
        if(ChooseLanguage.language == 1)//English
        {
            tex.text = "Play again!";
        }
        but.onClick.AddListener(delegate { click(); });
    }
	
    public void click()
    {
		if(HuntingHandler.end.activeInHierarchy == true)
        {
            Debug.Log("Working as intended");
            HuntingHandler.tutorial.SetActive(true);

            //reset timer
            GameObject.Find("Timer").GetComponent<CountDown>().resetTime();

            HitDectection.animalDoStuff = false; //name makes it seem like it's inverted but it's not
            SpawnAnimals.kills = 0;
            ShootArrow.arrowsShot = 0;
            HitDectection.hasHit = false;
            //HuntingHandler.end.SetActive(false);
            canvas.alpha = 0;
            canvas.interactable = false;
            canvas.blocksRaycasts = false;
            Debug.Log("End was disabled");
        }
    }
}
