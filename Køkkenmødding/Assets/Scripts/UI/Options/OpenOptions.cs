using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenOptions : MonoBehaviour {

    public Button button;
    CanvasGroup canvas;
	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("OptionsCanvas").GetComponent<CanvasGroup>();
        button.onClick.AddListener(delegate { click(); });
	}
	
	// Update is called once per frame
	void click()
    {
        //HierarchyHandler.optionsCanvas.SetActive(true);
        canvas.alpha = 1;
        canvas.interactable = true;
        canvas.blocksRaycasts = true;
    }
}
