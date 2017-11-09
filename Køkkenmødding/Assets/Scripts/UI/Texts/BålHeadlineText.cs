using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BålHeadlineText : MonoBehaviour {
    public Text tex;
	// Use this for initialization
	void Start () {
		
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            setText();
        }
    }
    void setText()
    {
        if (OpenModelInfo.danish == true)
        {
            tex.text = "Ildsted";
        }
        else
        {
            tex.text = "Cooking Fire";
        }
    }
}
