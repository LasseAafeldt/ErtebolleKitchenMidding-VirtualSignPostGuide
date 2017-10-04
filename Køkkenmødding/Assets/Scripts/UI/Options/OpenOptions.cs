using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenOptions : MonoBehaviour {

    public Button button;
	// Use this for initialization
	void Start () {
        button.onClick.AddListener(delegate { click(); });
	}
	
	// Update is called once per frame
	void click()
    {
        HierarchyHandler.optionsCanvas.SetActive(true);
    }
}
