using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneHunting : MonoBehaviour {

    CanvasGroup canvas;
    CanvasGroup load;
	void Start () {
        canvas = GameObject.Find("WorldSpace").transform.GetChild(0).GetComponent<CanvasGroup>();
        load = GameObject.Find("Loading").GetComponent<CanvasGroup>();
    }
    void OnMouseDown()
    {
        if(canvas.alpha == 0)
        {
            changeScene();
        }
    }

    void changeScene()
    {
        loading();
        SceneManager.LoadScene("HuntingGame");
    }
    void loading()
    {
        PlayerPrefs.SetInt("pFirst", IntroText.first);
        //Debug.Log("pFirst is " + PlayerPrefs.GetInt("pFirst"));
        load.alpha = 1;
        load.blocksRaycasts = true;
    }
}
