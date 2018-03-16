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
        setCamControl();
        gyro.onClick.AddListener(delegate { gyroClick(); });
        swipe.onClick.AddListener(delegate { swipeClick(); });
	}
	

    void gyroClick()
    {
        gyroscopeOn = true;
        setCamControl();
    }

    void swipeClick()
    {
        gyroscopeOn = false;
        setCamControl();
    }
    void setCamControl()
    {
        if (gyroscopeOn)
        {
            gameObject.GetComponent<driftTest>().enabled = true;
            gameObject.GetComponent<CameraTouch>().enabled = false;
        }
        if (!gyroscopeOn)
        {
            gameObject.GetComponent<driftTest>().enabled = false;
            gameObject.GetComponent<CameraTouch>().enabled = true;
        }
    }
}
