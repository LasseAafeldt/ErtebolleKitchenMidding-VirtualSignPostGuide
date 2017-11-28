using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetStartScreen : MonoBehaviour {

    void OnApplicationQuit()
    {
        Debug.Log("I have quit");
        PlayerPrefs.SetInt("pFirst", 0);
    }
}
