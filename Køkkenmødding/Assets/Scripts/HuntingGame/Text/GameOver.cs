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
        if (SpawnAnimals.kills == Goal.deerGoal)
        {
            if(ChooseLanguage.language == 0)//Danish
            {
                tex.text = "Yaay! Du skød " + SpawnAnimals.kills + " dyr!"
                    ;
            }
            if(ChooseLanguage.language == 1)//english
            {
                tex.text = "Yaay! You shot " + SpawnAnimals.kills + " Animals \n"
                    ;
            }
        }
        else if(HitDectection.hasHit == true)
        {
            if(ChooseLanguage.language == 0)//Danish
            {
                tex.text = "Du løb tør for tid, men, du skød " + SpawnAnimals.kills + " dyr!";
            }
            if(ChooseLanguage.language == 1)//English
            {
                tex.text = ("Sadly you ran out of time but you managed to shoot" + SpawnAnimals.kills + "animals!");
            }
        }
        else
        {
            if (ChooseLanguage.language == 0)//Danish
            {
                tex.text = "Du skød ikke noget på denne jagt.";
            }
            if (ChooseLanguage.language == 1)//English
            {
                tex.text = ("You didn't manage to secure any food on this hunt.");
            }
        }
    }
}
