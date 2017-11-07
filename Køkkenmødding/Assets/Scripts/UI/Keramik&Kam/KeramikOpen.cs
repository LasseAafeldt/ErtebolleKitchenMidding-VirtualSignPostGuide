using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeramikOpen : MonoBehaviour {

    CanvasGroup canvas;
    MeshRenderer model;

    public Button but;
    // Use this for initialization
    void Start()
    {

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
}