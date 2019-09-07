using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneMenu : MonoBehaviour {
    public Button button;
	public static float timePlay = 0.0f;
    CanvasGroup load;
	// Use this for initialization
	void Start () {
        load = GameObject.Find("Loading").GetComponent<CanvasGroup>();
        button.onClick.AddListener(delegate { click(); });
	}

    void click()
    {
		Debug.Log (Time.timeSinceLevelLoad);
		timePlay = timePlay + Time.timeSinceLevelLoad;
		PlayerPrefs.SetFloat ("game Time", timePlay);
        loading();
        SceneManager.LoadScene("Midding"); //if main scene name change change here aswell.
    }
    void loading()
    {
        load.alpha = 1;
        load.blocksRaycasts = true;
    }

}
