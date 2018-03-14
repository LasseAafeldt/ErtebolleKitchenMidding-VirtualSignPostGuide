using System.Collections;
using UnityEngine;

public class SecretVoice : MonoBehaviour {

    public float countDownTime;
    public float clickTimes;
    private int clicks = 0;
    public static bool secretVoiceEnabled = false;
    public GameObject disableButton;

    public void secretVoiceUnlock()
    {
        StartCoroutine(countDown(countDownTime));
        clicks++;
    }

    public void disableSecretVoice()
    {
        secretVoiceEnabled = false;
        disableButton.SetActive(false);    
    }

    IEnumerator countDown(float startTime)
    {
        int startClicks = clicks;
        int currentClicks = 0;
        while(startTime > 0)
        {
            if (secretVoiceEnabled)
            {
                yield break;
            }
            currentClicks = clicks - startClicks;
            Debug.Log("Current Clicks " + currentClicks);
            startTime -= Time.deltaTime;
            if(currentClicks >= clickTimes)
            {
                secretVoiceEnabled = true;
                disableButton.SetActive(true);
                Debug.Log("secrets = True");
            }
            yield return null;
        }
    }
}
