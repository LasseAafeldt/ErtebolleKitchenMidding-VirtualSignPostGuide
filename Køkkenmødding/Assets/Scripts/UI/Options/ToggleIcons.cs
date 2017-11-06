using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleIcons : MonoBehaviour {
    GameObject speaker;
    GameObject mute;
	// Use this for initialization
	void Start () {
        mute = GameObject.Find("MuteIcon");
        speaker = GameObject.Find("SpeakerIcon");
    }
	
	// Update is called once per frame
	void Update () {
        SoundToggle.volume = gameObject.GetComponent<Slider>().value;
        Debug.Log("volume = " + SoundToggle.volume);
		if(SoundToggle.volume == 0)//mute
        {
            mute.SetActive(true);
            speaker.SetActive(false);
        }

        if(SoundToggle.volume != 0)//sound
        {
            mute.SetActive(false);
            speaker.SetActive(true);
        }
	}
}
