using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogBut : MonoBehaviour {
    public Text dogTex;
	// Use this for initialization
	void Start () {
		if(ChooseLanguage.language == 0)
        {
            dogTex.text = "";
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
