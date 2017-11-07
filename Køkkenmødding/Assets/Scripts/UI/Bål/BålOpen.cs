﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BålOpen : MonoBehaviour {

    CanvasGroup canvas;
    MeshRenderer model;
	// Use this for initialization
	void Start () {
        canvas = gameObject.transform.parent.GetChild(1).GetComponent<CanvasGroup>();
        model = canvas.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<MeshRenderer>();
        hideInfoUI();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
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
        model.enabled = true;
    }

    void hideInfoUI()
    {
        canvas.alpha = 0;
        canvas.interactable = false;
        canvas.blocksRaycasts = false;
        model.enabled = false;
    }
}
