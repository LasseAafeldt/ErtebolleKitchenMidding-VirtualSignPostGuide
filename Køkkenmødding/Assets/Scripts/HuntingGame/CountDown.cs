using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

    public Text timer;
    public float time;

    public static float tempTime;
    // Use this for initialization
    void Start()
    {
        timer.text = ("Time left = " + time);
        tempTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (HuntingHandler.tutorial.activeInHierarchy == false && HuntingHandler.end.activeInHierarchy == false)
        {
            time -= Time.deltaTime;
            timer.text = ("Time left = " + (int)time);
        }
        if (time <= 0 && HuntingHandler.end.activeInHierarchy == false)
        {
            StartCoroutine(end());
        }
    }
    public void resetTime()
    {
        time = tempTime;
        Debug.Log("time was reset");
    }

    public IEnumerator end()
    {
        yield return new WaitForSeconds(0);
        HuntingHandler.end.SetActive(true);
        HitDectection.animalDoStuff = true;
    }
}
