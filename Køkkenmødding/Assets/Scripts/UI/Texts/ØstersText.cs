using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ØstersText : MonoBehaviour {
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
            tex.text = "Køkkenmøddingen består af store mængder af østersskaller fra de østers Ertebøllefolket har spist.\n" +
                "Der er dog ikke nok næring i østers til at man ville kunne nøjes med at spise dem. (BILLEDE AF ØSTERSLAG)";
        }
        else
        {
            tex.text = "Not Found yet!";
        }
    }
}
