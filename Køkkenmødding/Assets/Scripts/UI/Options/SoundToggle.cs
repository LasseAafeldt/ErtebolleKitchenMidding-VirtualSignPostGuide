using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour {

	// Use this for initialization
    public Toggle sound;
    private float tempVolume;
    public static float volume;
    GameObject speaker;
    GameObject mute;

	void Start () {
        speaker = GameObject.Find("SpeakerIcon");
        mute = GameObject.Find("MuteIcon");
        volume = GameObject.Find("Slider").GetComponent<Slider>().value;
        sound.isOn = true;
        speaker.SetActive(true);
        mute.SetActive(false);
        sound.onValueChanged.AddListener(delegate { valueChanged(); });
    }
	
	// Update is called once per frame

   void valueChanged()
    {
        if(sound.isOn == true)
        {
            GameObject.Find("Slider").GetComponent<Slider>().value = tempVolume;
            Debug.Log("volume: " + volume);
            speaker.SetActive(true);
            mute.SetActive(false);
        }
        if(sound.isOn == false)
        {
            tempVolume = volume;
            //volume = 0;
            GameObject.Find("Slider").GetComponent<Slider>().value = 0;
            Debug.Log("volume: " + volume);
            speaker.SetActive(false);
            mute.SetActive(true);
        }
    }
}

