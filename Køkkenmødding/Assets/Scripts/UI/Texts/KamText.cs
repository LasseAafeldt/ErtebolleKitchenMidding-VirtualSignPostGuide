using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KamText : MonoBehaviour {

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
            tex.text = " I møddingen er der fundet to kamme, så man har måske haft flotte opsatte frisurer. (BILLEDE AF KAM)";
        }
        else
        {
            tex.text = "Not Found yet!";
        }
    }
}

