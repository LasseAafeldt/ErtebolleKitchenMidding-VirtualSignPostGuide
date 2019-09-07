using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MogensText : MonoBehaviour {
    public static Text tex;
	// Use this for initialization
	void Start () {
        tex = gameObject.GetComponent<Text>();
	}
    public static void setText()
    {
        if (OpenModelInfo.danish)
        {
            tex.text = "Lad mig \n" +
                "fortælle!";
        }
        if (!OpenModelInfo.danish)
        {
            tex.text = "Let me \n" +
                "speak!";
        }
    }
}
