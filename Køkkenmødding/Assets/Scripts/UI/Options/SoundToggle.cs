using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour {

	// Use this for initialization
    public Toggle sound;
    private int tempVolume = 1;
    public static int volume = 10;

	void Start () {
        this.sound.onValueChanged.AddListener(delegate { valueChanged(); });

    }
	
	// Update is called once per frame

   void valueChanged()
    {
        if(sound.isOn == true)
        {
            volume = tempVolume;
            Debug.Log("volume: " + volume);
        }
        if(sound.isOn == false)
        {
            tempVolume = volume;
            volume = 0;
            Debug.Log("volume: " + volume);
        }
    }
}

