using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleIcons : MonoBehaviour {
    GameObject speaker;
    GameObject mute;
	// Use this for initialization
	void Start () {
        //HierarchyHandler.optionsCanvas.SetActive(true);
        mute = HierarchyHandler.mute;
        speaker = HierarchyHandler.speaker;
        //Debug.Log("start status = " + mute);
    }
	
	// Update is called once per frame
	/*void Update () {
        SoundToggle.volume = gameObject.GetComponent<Slider>().value;
        Debug.Log("volume = " + SoundToggle.volume);
		if(SoundToggle.volume == 0)//mute
        {
            mute.SetActive(true);
            speaker.SetActive(false);
        }

        if(SoundToggle.volume != 0)//sound
        {
            if(mute.activeInHierarchy == true)
            {
                mute.SetActive(false);
            }
            speaker.SetActive(true);
        }
	}*/
}
