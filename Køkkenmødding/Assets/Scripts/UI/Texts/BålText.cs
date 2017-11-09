using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BålText : MonoBehaviour {

    public Text tex;
	// Use this for initialization
	void Start () {
        setText();
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
            tex.text = "Møddingen var i dagligdagen et opholdssted og centrum for det daglige arbejde.\n" +
                "Folk tilberedte deres mad på et ildsted ved møddingen og spiste derude."
                ;
        }
        else
        {
            tex.text = "The midden was the centre of the everyday life and work. The Ertebølle people cooked and ate at the midden.";
        }
    }
}
