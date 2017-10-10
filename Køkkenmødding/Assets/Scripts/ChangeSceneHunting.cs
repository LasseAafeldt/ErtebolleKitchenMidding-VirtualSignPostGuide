using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneHunting : MonoBehaviour {

    
	void Start () {
        
	}
    void OnMouseDown()
    {
        changeScene();
    }

    void changeScene()
    {
        SceneManager.LoadScene("HuntingGame");
    }
}
