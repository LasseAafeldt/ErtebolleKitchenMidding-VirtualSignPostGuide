using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseLanguage : MonoBehaviour {

    public Button button;
    public static int language; // 0 = Danish, 1 = English,
    public Color selected;
    public Color deSelected;
	// Use this for initialization
	void Start () {
        selected = new Color(0.58F, 0.58F, 0.58F, 0.58F);
        deSelected = new Color(0, 0, 0, 0);
        language = 0;
        GameObject.Find("DanishEdge").gameObject.GetComponent<RawImage>().color = selected;
        button.onClick.AddListener(delegate { click(); });
	}
	
	void click()
    {
        if (button.CompareTag("Danish"))
        {
            language = 0;
            Debug.Log("Dansk");

            gameObject.transform.parent.gameObject.GetComponent<RawImage>().color = selected;
            GameObject.Find("EnglishEdge").gameObject.GetComponent<RawImage>().color = deSelected;

        }
        if (button.CompareTag("English"))
        {
            language = 1;
            Debug.Log("English");
            gameObject.transform.parent.gameObject.GetComponent<RawImage>().color = selected;
            GameObject.Find("DanishEdge").gameObject.GetComponent<RawImage>().color = deSelected;
        }
    }

}
