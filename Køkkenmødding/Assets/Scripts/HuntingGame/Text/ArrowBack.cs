using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArrowBack : MonoBehaviour {
    public Text tex;
	// Use this for initialization
	void Start () {
		if(ChooseLanguage.language == 0)
        {
            tex.text = "Tryk for at få en ny pil";
        }
        if(ChooseLanguage.language == 1)
        {
            tex.text = "Tap to get a new arrow";
        }
	}
}
