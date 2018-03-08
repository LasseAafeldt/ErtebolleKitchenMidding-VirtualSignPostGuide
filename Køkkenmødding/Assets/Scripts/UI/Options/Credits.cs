using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour {
    public Text header;
    public Text subText;
    public Text creditsButText;
    public GameObject credits;
    public AnimationClip aniToTerminateAfter;

    void Update()
    {
        if(ChooseLanguage.language == 0)
        {
            creditsButText.text = "Anerkendelser";
            header.text = "Anerkendelser";
            subText.text = "Denne app er udviklet som et semesterprojekt på Aalborg Universitet \n" +
                "\n" +
                "Denne app er udviklet af: \n" +
                "Liv Arleth \n" +
                "Emilie Lind Damkjær \n" +
                "Johan Winther Kristensen \n" +
                "Rebecca Pipaluk Kappelgaard Toft \n" +
                "Lasse Lodberg Aafeldt \n" +
                "\n" +
                "I samarbejde med: \n" +
                "Stenaldercenter Ertebølle \n" +
                "Vesthimmerland Museum \n" +
                "\n" +
                "Stemmer: \n" +
                "Terkel Hatting-Kristiansen \n" +
                "\n" +
                "Særlig tak til: \n" +
                "Louise Villadsen \n" +
                "\n" +
                "Skabt med Unity og Autodesk Maya";
        }

        if(ChooseLanguage.language == 1)
        {
            creditsButText.text = "Credits";
            header.text = "Credits";
            subText.text = "This app was developed as a semester project at Aalborg University \n" +
                "\n" +
                "This app was developed by: \n" +
                "Liv Arleth \n" +
                "Emilie Lind Damkjær \n" +
                "Johan Winther Kristensen \n" +
                "Rebecca Pipaluk Kappelgaard Toft \n" +
                "Lasse Lodberg Aafeldt \n" +
                "\n" +
                "In collaboration with: \n" +
                "Stenaldercenter Ertebølle \n" +
                "Vesthimmerland Museum \n" +
                "\n" +
                "Voice acting: \n" +
                "Terkel Hatting-Kristiansen \n" +
                "\n" +
                "Special thanks to: \n" +
                "Louise Villadsen \n" +
                "\n" +
                "Made with Unity and Autodesk Maya";
        }
    }
    public void openCredits()
    {
        credits.SetActive(true);
        StartCoroutine(endCredits());
    }
    IEnumerator endCredits()
    {
        yield return new WaitForSeconds(aniToTerminateAfter.length);
        credits.SetActive(false);
    }

}
