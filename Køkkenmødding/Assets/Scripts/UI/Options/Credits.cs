using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour {
    public Text header;
    public Text subText;
	public Text voresNavne;
	public Text voiceActorPlus;
	public Text creditsTitle;
    public Text creditsButText;
    public GameObject credits;
    public AnimationClip aniToTerminateAfter;

    void Update()
    {
        if(ChooseLanguage.language == 0)
        {
            creditsButText.text = "Anerkendelser";
            header.text = "Anerkendelser";
            subText.text = "Denne app er udviklet som et semesterprojekt på Aalborg \n"+ 
				"Universitet i samarbejde med Stenaldercenter Ertebølle \n" +
                "og Vesthimmerland Museum \n";
			voresNavne.text = "Denne app er udviklet af: \n" +
				"Liv Arleth \n" +
				"Emilie L. Damkjær \n" +
				"Johan W. Kristensen \n" +
				"Rebecca P. K. Toft \n" +
				"Lasse L. Aafeldt \n" ;
			voiceActorPlus.text =  "Stemmer: \n" +
				"Terkel Hatting-Kristiansen \n" +
				"\n" +
				"Særlig tak til: \n" +
				"Louise Villadsen \n" +
				"\n" +
				"Skabt med \n"+ 
				"Unity og Autodesk Maya";
			creditsTitle.text = "Anerkendelser";
        }

        if(ChooseLanguage.language == 1)
        {
            creditsButText.text = "Credits";
            header.text = "Credits";
			subText.text = "This app was developed as a semester project at Aalborg \n" +
				"University in collaboration with Stenaldercenter Ertebølle \n" +
				"and Vesthimmerland Museum \n";
			voresNavne.text = "This app was developed by: \n" +
				"Liv Arleth \n" +
				"Emilie L. Damkjær \n" +
				"Johan W. Kristensen \n" +
				"Rebecca P. K. Toft \n" +
				"Lasse L. Aafeldt \n";
			voiceActorPlus.text = "Voice acting: \n" +
				"Terkel Hatting-Kristiansen \n" +
				"\n" +
				"Special thanks to: \n" +
				"Louise Villadsen \n" +
				"\n" +
				"Made with \n"+
				"Unity and Autodesk Maya";
			creditsTitle.text = "Credits";
        }
    }
    public void openCredits()
    {
        credits.SetActive(true);
        //StartCoroutine(endCredits());
    }

	public void closeCredits()
	{
		credits.SetActive (false);
	}
    IEnumerator endCredits()
    {
        yield return new WaitForSeconds(aniToTerminateAfter.length);
        credits.SetActive(false);
    }

}
