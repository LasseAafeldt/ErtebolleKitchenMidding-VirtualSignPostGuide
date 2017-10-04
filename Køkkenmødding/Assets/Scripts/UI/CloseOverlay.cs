using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseOverlay : MonoBehaviour {
    public Button button;

	// Use this for initialization
	void Start () {
        
        button.onClick.AddListener(delegate { click(); });
	}
	
	// Update is called once per frame
    void click()
    {
        if (HierarchyHandler.cookingFacts.activeInHierarchy == true)
        {
            HierarchyHandler.cookingFacts.SetActive(false);
        }

        Debug.Log("im running overlay");
        HierarchyHandler.closeoverlay.SetActive(false);
    }
}
