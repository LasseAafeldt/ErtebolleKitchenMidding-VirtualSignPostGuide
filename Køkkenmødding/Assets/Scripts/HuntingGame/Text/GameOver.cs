using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text tex;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HitDectection.hasHit == true)
        {
            if(ChooseLanguage.language == 0)//Danish
            {
                tex.text = "Yaaay! Du skød " + SpawnAnimals.kills + " dyr!"
                    ;
            }
            if(ChooseLanguage.language == 1)//english
            {
                tex.text = "Yaaay! You shot " + SpawnAnimals.kills + " Animals \n"
                    ;
            }
        }
        else
        {
            if(ChooseLanguage.language == 0)//Danish
            {
                tex.text = "Det var ærgeligt. Du fik ikke ramt nogen dyr.";
            }
            if(ChooseLanguage.language == 1)//English
            {
                tex.text = ("Too bad. You ran out of time");
            }
        }
    }
}
