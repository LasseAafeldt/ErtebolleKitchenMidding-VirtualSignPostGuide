using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour {
    public Slider volumeSlider;
    public AudioSource audioSrc;
    float startVolume;

    public void Start()
    {
        //Adds a listener to the main slider and invokes a method when the value changes.
        volumeSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        startVolume = audioSrc.volume;
    }

    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
        //Debug.Log(volumeSlider.value);
        audioSrc.volume = (volumeSlider.value / volumeSlider.maxValue) * startVolume;
    }
}
