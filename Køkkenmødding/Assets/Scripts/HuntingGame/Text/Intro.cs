using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    public Text tex;

    // Use this for initialization
    void Start()
    {

        if (ChooseLanguage.language == 0)//Danish
        {
            tex.text = "Velkommen til Jæger spillet! \n"+
                "\n"+
                "Når du starter spillet har du 60 sekunder til at skyde\n"+ 
                "så mange dyr som muligt.\n"+
                "\n"+
                "For at skyde skal du trykke på skærmen.\n"+
                "For at få en ny pil skal du trykke på skærmen igen.\n"+
                "\n"+
                "God jagt!"
                ;
        }
        if (ChooseLanguage.language == 1)//English
        {
            tex.text = "Not yet implemented";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
