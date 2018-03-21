using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {
    CanvasGroup canvas;
    public Text timer;
    public float time;

    public static float tempTime;
    CanvasGroup endUI;
    // Use this for initialization
    void Start()
    {
        timer.text = ("= " + time);
        tempTime = time;
        endUI = GameObject.Find("EndOfGame").GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (HuntingHandler.tutorial.activeInHierarchy == false && endUI.alpha == 0)
        {
            time -= Time.deltaTime;
            timer.text = ("= " + (int)time);
        }
        if (time <= 0 || SpawnAnimals.kills == Goal.deerGoal && endUI.alpha == 0)
        {
            StartCoroutine(end());
        }
    }
    public void resetTime()
    {
        time = tempTime;
        //Debug.Log("time was reset");
    }

    public IEnumerator end()
    {
        yield return new WaitForSeconds(0);
        //HuntingHandler.end.SetActive(true);
        showEndUI();
        canvas = GameObject.Find("EndOfGame").GetComponent<CanvasGroup>();
        canvas.alpha = 1;
        canvas.interactable = true;
        canvas.blocksRaycasts = true;
        HitDectection.animalDoStuff = true;
    }

    void showEndUI()
    {
        endUI.alpha = 1;
        endUI.interactable = true;
        endUI.blocksRaycasts = true;
    }
}
