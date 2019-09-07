using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitApp : MonoBehaviour {
    public Button exit;

    public void exitApp()
    {
        Application.Quit();
    }
}
