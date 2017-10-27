using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour {
    public Button but;
	// Use this for initialization
	void Start () {
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
            HuntingHandler.end.SetActive(false);
        }
    }
}
