using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour {
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(HitDectection.animalDoStuff == true)
        {
            text.text = ("Congratulations you hit the animal!");
        }
        else
        {
            text.text = ("Too bad. You ran out of time");
        }
	}
}
