using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroNotEnabled : MonoBehaviour {
    public Text tex;
    public Text enableGyroButText;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () { //use a listerner instead of this everywhere to improve efficeincy
        if (ChooseLanguage.language == 0)
        {
            tex.text = "Dit device har intet gyroskop! \n" +
                "Vil du slå touch control til?";
            enableGyroButText.text = "Slå touch control til";
        }
        if (ChooseLanguage.language == 1)
        {
            tex.text = "Your device does not have a gyroscope! \n" +
                "Would you like to enable touch control?";
            enableGyroButText.text = "Enable touch control";
        }
    }
}
