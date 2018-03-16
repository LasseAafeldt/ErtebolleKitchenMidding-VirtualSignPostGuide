using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseOptions : MonoBehaviour {
    CanvasGroup canvas;
    public Button button;
	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("OptionsCanvas").GetComponent<CanvasGroup>();
        button.onClick.AddListener(delegate { click(); });
	}

    // Update is called once per frame
    void click()
    {
        //HierarchyHandler.optionsCanvas.SetActive(false);
        canvas.alpha = 0;
        canvas.interactable = false;
        canvas.blocksRaycasts = false;
        //Debug.Log("im running options");
    }
}
