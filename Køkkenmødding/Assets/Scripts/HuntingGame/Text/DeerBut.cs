using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeerBut : MonoBehaviour {
    public Text deerTex;
	// Use this for initialization
	void Start () {
		if(ChooseLanguage.language == 0)//Danish
        {
            deerTex.text = "Tryk for mere info";
        }
        if(ChooseLanguage.language == 1)//english
        {
            deerTex.text = "press for more info";
        }
	}
}
