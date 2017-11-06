using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationMethod : MonoBehaviour
{

    public Button button;
    public bool gyro;
    public Color selected;
    public Color deSelected;
    // Use this for initialization
    void Start()
    {
        selected = new Color(0.58F, 0.58F, 0.58F, 0.58F);
        deSelected = new Color(0, 0, 0, 0);
        gyro = true;
        GameObject.Find("Gyro").GetComponent<RawImage>().color = selected;
        button.onClick.AddListener(delegate { click(); });
    }

    void click()
    {
        if (button.CompareTag("Gyro"))
        {
            gyro = true;
            Debug.Log("gyro");

            gameObject.transform.parent.gameObject.GetComponent<RawImage>().color = selected;
            GameObject.Find("Finger").gameObject.GetComponent<RawImage>().color = deSelected;

        }

        if (button.CompareTag("Finger"))
        {
            gyro = false;
            Debug.Log("finger");

            gameObject.transform.parent.gameObject.GetComponent<RawImage>().color = selected;
            GameObject.Find("Gyro").gameObject.GetComponent<RawImage>().color = deSelected;

        }
    }
}
