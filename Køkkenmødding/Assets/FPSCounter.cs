using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour {

    Text tex;

	void Start () {
        tex = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        float fps = 1 / Time.deltaTime;
        tex.text = "FPS = " + fps.ToString();
	}
}
