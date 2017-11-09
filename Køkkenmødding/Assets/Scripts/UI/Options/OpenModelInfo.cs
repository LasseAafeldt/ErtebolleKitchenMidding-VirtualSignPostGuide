using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenModelInfo : MonoBehaviour {

    CanvasGroup canvas;
    MeshRenderer model;
    public static bool danish;

    public Button but;
    // Use this for initialization
    void Start()
    {
        checkLanguage();
        canvas = gameObject.transform.parent.GetChild(0).GetComponent<CanvasGroup>();
        //model = canvas.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<MeshRenderer>();
        hideInfoUI();
        but.onClick.AddListener(delegate { hideInfoUI(); });
    }

    // Update is called once per frame

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            checkLanguage();
            showInfoUI();
        }
    }

    void showInfoUI()
    {
        canvas.alpha = 1;
        canvas.interactable = true;
        canvas.blocksRaycasts = true;
    }

    void hideInfoUI()
    {
        canvas.alpha = 0;
        canvas.interactable = false;
        canvas.blocksRaycasts = false;
    }

    void checkLanguage()
    {
        if(ChooseLanguage.language == 0)
        {
            danish = true;
            Debug.Log("Danish");
        }
        else
        {
            danish = false;
            Debug.Log("English");
        }
    }
}
