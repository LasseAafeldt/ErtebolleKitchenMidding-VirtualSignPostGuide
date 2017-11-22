using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMethodController : MonoBehaviour {
    public Button swipe;
    public Button gyro;
    public static bool gyroscopeOn;
	// Use this for initialization
	void Start () {
        gyroscopeOn = true;
        gyro.onClick.AddListener(delegate { gyroClick(); });
        swipe.onClick.AddListener(delegate { swipeClick(); });
	}
	
	// Update is called once per frame
	void Update () {
        if (gyroscopeOn)
        {
            gameObject.GetComponent<CameraControl3>().enabled = true;
            gameObject.GetComponent<CameraTouch>().enabled = false;
        }
        if (!gyroscopeOn)
        {
            gameObject.GetComponent<CameraControl3>().enabled = false;
            gameObject.GetComponent<CameraTouch>().enabled = true;
        }
	}

    void gyroClick()
    {
        gyroscopeOn = true;
    }

    void swipeClick()
    {
        gyroscopeOn = false;
    }
}
