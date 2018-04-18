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

    bool hasPlayed = false;

    string model;
    //AudioClip audio;
	void Start () {
        audioArray = Resources.LoadAll<AudioClip>("Audio/Voice/Dansk");//load all audioclips in this folder
        audioArrayEnglish = Resources.LoadAll<AudioClip>("Audio/Voice/Engelsk");//load all audioclips in this folder
        but.onClick.AddListener(delegate { click(); });

	}
	
    void click()
    {
        if (Camera.main.GetComponent<AudioSource>().isPlaying)
        {
            return;
        }
        model = OpenModelInfo.model;
        voice = true;
        GameObject.Find("speechbubble").GetComponent<CanvasGroup>().alpha = 0;
        GameObject.Find("speechbubble").GetComponent<CanvasGroup>().interactable = false;
        //Debug.Log("voice = " + voice);

        StartCoroutine(selectSound());

    }

    IEnumerator selectSound()
    {
        AudioClip currentClip;
        if(ChooseLanguage.language == 0)
        {
            for(int i = 0; i < audioArray.Length; i++)
            {
                if(model == audioArray[i].name && hasPlayed == false)
                {
                    Debug.Log("secrets = " + SecretVoice.secretVoiceEnabled);
                    if (SecretVoice.secretVoiceEnabled)
                    {
                        Camera.main.GetComponent<AudioSource>().clip = audioArray[i+1];
                        currentClip = audioArray[i + 1];
                    }
                    else
                    {
                        Camera.main.GetComponent<AudioSource>().clip = audioArray[i];
                        currentClip = audioArray[i];
                    }
                    if(hasPlayed == false)
                    {
                        Camera.main.GetComponent<AudioSource>().Play();
                        hasPlayed = true;
				        audioPlayed++;
                    }
                    yield return new WaitForSeconds(currentClip.length);
                    voice = false;
                    GameObject.Find("speechbubble").GetComponent<CanvasGroup>().alpha = 1;
                    GameObject.Find("speechbubble").GetComponent<CanvasGroup>().interactable = true;
                    hasPlayed = false;
                    yield break;
                }
            }
        }
        if(ChooseLanguage.language == 1)
        {
            for (int i = 0; i < audioArrayEnglish.Length; i++)
            {
                if (model == audioArrayEnglish[i].name)
                {
                    Debug.Log("Audio Array contains: " + audioArrayEnglish.Length);
                    Debug.Log(audioArrayEnglish[i].name);
                    Camera.main.GetComponent<AudioSource>().clip = audioArrayEnglish[i];
                    Camera.main.GetComponent<AudioSource>().Play();
                    audioPlayed++;
                    yield return new WaitForSeconds(audioArrayEnglish[i].length);
                    voice = false;
                    GameObject.Find("speechbubble").GetComponent<CanvasGroup>().alpha = 1;
                }
            }
        }
    }
 }

