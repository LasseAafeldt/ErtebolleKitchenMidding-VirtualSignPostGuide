using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseLanguage : MonoBehaviour {

    public Button button;
    public static int language; // 0 = Danish, 1 = English,
	// Use this for initialization
	void Start () {
        language = 0;
        
        button.onClick.AddListener(delegate { click(); });
	}
	
	void click()
    {
        if (button.CompareTag("Danish"))
        {
            language = 0;
            Debug.Log("Dansk");
        }
        if (button.CompareTag("English"))
        {
            language = 1;
            Debug.Log("English");
        }
    }

}
