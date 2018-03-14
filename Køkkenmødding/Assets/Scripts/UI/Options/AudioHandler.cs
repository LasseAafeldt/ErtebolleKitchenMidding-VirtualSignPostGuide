using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioHandler : MonoBehaviour {
    public Button but;
    public static bool voice;
	public static int audioPlayed = 0;
    AudioClip[] audioArray;
    AudioClip[] audioArrayEnglish;

    string model;
    //AudioClip audio;
	void Start () {
        audioArray = Resources.LoadAll<AudioClip>("Audio/Voice/Dansk");//load all audioclips in this folder
        audioArrayEnglish = Resources.LoadAll<AudioClip>("Audio/Voice/Engelsk");//load all audioclips in this folder
        but.onClick.AddListener(delegate { click(); });

	}
	
    void click()
    {
        model = OpenModelInfo.model;
        voice = true;
        GameObject.Find("speechbubble").GetComponent<CanvasGroup>().alpha = 0;
        Debug.Log("voice = " + voice);
        StartCoroutine(selectSound());

    }

    IEnumerator selectSound()
    {
        if(ChooseLanguage.language == 0)
        {
            for(int i = 0; i < audioArray.Length; i++)
            {
                if(model == audioArray[i].name)
                {
                    Camera.main.GetComponent<AudioSource>().clip = audioArray[i];
                    Camera.main.GetComponent<AudioSource>().Play();
				    audioPlayed++;
                    yield return new WaitForSeconds(audioArray[i].length);
                    voice = false;
                    GameObject.Find("speechbubble").GetComponent<CanvasGroup>().alpha = 1;
                }
            }
        }
        if(ChooseLanguage.language == 1)
        {
            for (int i = 0; i < audioArrayEnglish.Length; i++)
            {
                Debug.Log(audioArrayEnglish[i].name);
                if (model == audioArrayEnglish[i].name)
                {
                    Camera.main.GetComponent<AudioSource>().clip = audioArray[i];
                    Camera.main.GetComponent<AudioSource>().Play();
                    audioPlayed++;
                    yield return new WaitForSeconds(audioArray[i].length);
                    voice = false;
                    GameObject.Find("speechbubble").GetComponent<CanvasGroup>().alpha = 1;
                }
            }
        }
    }
 }

