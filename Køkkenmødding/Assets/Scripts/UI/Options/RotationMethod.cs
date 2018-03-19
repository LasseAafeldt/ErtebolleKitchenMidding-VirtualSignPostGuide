using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationMethod : MonoBehaviour
{

    public Button button;
    public static bool gyro;
    public Color selected;
    public Color deSelected;
	public GameObject FingerObj;
	public GameObject GyroObj;
    // Use this for initialization
    void Start()
    {
        selected = new Color(0.58F, 0.58F, 0.58F, 0.58F);
        deSelected = new Color(0, 0, 0, 0);
        gyro = true;
        CheckGyro();
        GameObject.Find("Gyro").GetComponent<RawImage>().color = selected;
        button.onClick.AddListener(delegate { click(); });
    }

    public void setSwipeControl()
    {
        gyro = false;
        CheckGyro();
        Debug.Log("finger");

        GameObject.Find("Finger").gameObject.GetComponent<RawImage>().color = selected;
        GameObject.Find("Gyro").gameObject.GetComponent<RawImage>().color = deSelected;
        GameObject.Find("Main Camera").gameObject.GetComponent<CameraControl3>().enabled = false;
        GameObject.Find("Main Camera").gameObject.GetComponent<CameraTouch>().enabled = true;
    }

    public bool CheckGyro()
    {
        if(gyro == false)
        {
            Input.gyro.enabled = false;
            return false;
        }
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
            return true;
        }
        //should probably pull up the gyro UI again here
        return false;
    }


    void click()
    {
        if (button.CompareTag("Gyro"))
        {
            gyro = true;
            CheckGyro();
            Debug.Log("gyro");

			GameObject.Find("Gyro").gameObject.transform.gameObject.GetComponent<RawImage>().color = selected;
            GameObject.Find("Finger").gameObject.GetComponent<RawImage>().color = deSelected;
			GameObject.Find("Main Camera").gameObject.GetComponent<CameraControl3>().enabled = true;
			GameObject.Find("Main Camera").gameObject.GetComponent<CameraTouch>().enabled = false;

        }

        if (button.CompareTag("Finger"))
        {
            gyro = false;
            CheckGyro();
            Debug.Log("finger");

			GameObject.Find("Finger").gameObject.transform.gameObject.GetComponent<RawImage>().color = selected;
            GameObject.Find("Gyro").gameObject.GetComponent<RawImage>().color = deSelected;
			GameObject.Find("Main Camera").gameObject.GetComponent<CameraControl3>().enabled = false;
			GameObject.Find("Main Camera").gameObject.GetComponent<CameraTouch>().enabled = true;

        }
    }
}
