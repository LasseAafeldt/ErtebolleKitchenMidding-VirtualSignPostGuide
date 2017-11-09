using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KeramikText : MonoBehaviour {

    public Text tex;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
            tex.text = " I Danmark var Ertebøllefolket de første til at bruge keramik. (BILLEDE AF KERAMIK)";
        }
        else
        {
            tex.text = "Not Found yet!";
        }
    }
}
