using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenModelInfo : MonoBehaviour {

    CanvasGroup canvas;
    public static bool danish;
    public Text headline;
    public Text tex;
    public Button backBut;
    public static string model;
    public Button gameBut;

    Vector3 position;
    Object prefab;
    Quaternion rotation;
    Transform modelPosition;
    CanvasGroup startUP;
    CanvasGroup options;

    void Start()
    {
        if(SceneManager.GetActiveScene().name == "HuntingGame")
        {
            gameBut.onClick.AddListener(delegate { click(); });
        }
        Debug.Log("running start!!!");
        modelPosition = GameObject.Find("ModelPosition").transform;
        checkLanguage();
        canvas = GameObject.Find("WorldSpace").transform.GetChild(0).GetComponent<CanvasGroup>();
        model = "0";
        hideInfoUI();

        position = GameObject.Find("ModelPosition").transform.position;
        rotation = GameObject.Find("ModelPosition").transform.rotation;

        if(SceneManager.GetActiveScene().name == "Midding")
        {
            startUP = GameObject.Find("StartUpScreen").GetComponent<CanvasGroup>();
            options = GameObject.Find("OptionsCanvas").GetComponent<CanvasGroup>();
        }

        backBut.onClick.AddListener(delegate { hideInfoUI(); });
    }

    void click()
    {
        if(canvas.alpha == 0)
        {
            checkLanguage();
            showInfoUI();
            MogensText.setText();
            model = gameObject.transform.parent.name;
            setText();
            Debug.Log(model);
            selectPrefab();
            GameObject clone = Instantiate((GameObject)prefab, position, rotation, GameObject.Find("ModelPosition").transform);
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && canvas.alpha == 0 && startUP.alpha == 0 && options.alpha == 0)
        {
            checkLanguage();
            showInfoUI();
            MogensText.setText();
            model = gameObject.transform.parent.name;
            setText();
            Debug.Log(model);
            selectPrefab();
            GameObject clone = Instantiate( (GameObject)prefab, position, rotation,GameObject.Find("ModelPosition").transform);  
        }
    }

    void selectPrefab()
    {

        if (model == "Bål")
        {
            prefab = Resources.Load("ModBål");
        }
        if(model == "Keramik")
        {
            Debug.Log("test");
            prefab = Resources.Load("ModKeramik");
        }
        if(model == "Kam")
        {
            prefab = Resources.Load("ModKam");
        }
        if(model == "Østers")
        {
            prefab = Resources.Load("ModØsters");
        }
        if(model == "Fisk")
        {
            Debug.Log("Entered!!!");
            prefab = Resources.Load("ModFisk");
        }
        if(model == "Hund")
        {
            prefab = Resources.Load("ModHund");
        }
        if(model == "Skelet")
        {
            prefab = Resources.Load("ModSkelet");
        }
        if(model == "Hasselnød")
        {
            prefab = Resources.Load("ModHasselnød");
        }
        if(model == "Dyr")
        {
            prefab = Resources.Load("ModDyr");
        }
        if(model == "Tværpil")
        {
            prefab = Resources.Load("ModTværpil");
        }
        if(model == "Mødding")
        {
            prefab = Resources.Load("ModMødding");
            GameObject.Find("Spotlight").GetComponent<Light>().intensity = 10;
        }
        if(model == "Havet")
        {
            prefab = Resources.Load("ModHav");
        }
    }

    void showInfoUI()
    {
        canvas.alpha = 1;
        canvas.interactable = true;
        canvas.blocksRaycasts = true;

    }

    void hideInfoUI()
    {
        if(model == gameObject.transform.parent.name || model == "0" || SceneManager.GetActiveScene().name == "HuntingGame")
        {
            Debug.Log("running hideUIInfo()");
            for (int i = 0; i < modelPosition.childCount; i++)
            {
                Destroy(modelPosition.GetChild(0).gameObject);
                Debug.Log("I Destroyed a Child");
            }
            AudioHandler.voice = false;
            Camera.main.GetComponent<AudioSource>().Stop();
            GameObject.Find("Spotlight").GetComponent<Light>().intensity = 1;
            GameObject.Find("speechbubble").GetComponent<CanvasGroup>().alpha = 1;
            // GameObject.Find("Scroll View").GetComponent<ScrollRect>().horizontalNormalizedPosition = 1;
            canvas.alpha = 0;
            canvas.interactable = false;
            canvas.blocksRaycasts = false;
            //Debug.Log("this was done");
        }
    }

    void checkLanguage()
    {
        if(ChooseLanguage.language == 0)
        {
            danish = true;
            Debug.Log("Danish");
        }
        else
        {
            danish = false;
            Debug.Log("English");
        }
    }

    void setText()
    {
        if(model == "Mødding")
        {
            if (danish)
            {
                headline.text = "Affaldsbunke";
                tex.text = "Denne køkkenmødding gav navn til en hel periode af stenalderen: Ertebølletiden, som startede for 7400 år siden og varede 1500 år. Møddingen var menneskeskabt og bestod primært af køkkenaffald. Møddingen har strakt sig mindst 140 meter, og har bredt sig over 20 meter fra kystlinjen ind mod land, og været helt op til 1,9 meter høj.";
            }
            else
            {
                headline.text = "Midden";
                tex.text = "This kitchen midden lends its name to a whole period of the stone age: the Ertebølle period, which started 7400 years ago and lasted 1500 years. The midden was man made and consisted primarily of kitchen waste. The midden was at least 140 meters long and 20 meters wide starting from the coastline going inland. The midden was up to 1.9 meters at its tallest.";
            }
        }
        if(model == "Bål")
        {
            if (danish)
            {
                headline.text = "Ildsted";
                tex.text = "Møddingen var i dagligdagen et opholdssted og centrum for det daglige arbejde.\n" +
                "Folk tilberedte deres mad på et ildsted ved møddingen og spiste derude."
                ;
            }
            else
            {
                headline.text = "Cooking Fire";
                tex.text = "The midden was the centre of the everyday life and work."+ 
                    "The Ertebølle people cooked and ate at the midden.";
            }
        }
        if(model == "Keramik")
        {
            if (danish)
            {
                headline.text = "Keramik";
                tex.text = "I Danmark var Ertebøllefolket de første til at bruge keramik." 
                   ;
            }
            else
            {
                headline.text = "Ceramics";
                tex.text = "In Denmark, the Ertebølle people were the first to use ceramics.";
            }
        }
        if(model == "Kam")
        {
            if (danish)
            {
                headline.text = "Kam";
                tex.text = "I møddingen er der fundet to kamme, så man har måske haft flotte opsatte frisurer.";
            }
            else
            {
                headline.text = "Comb";
                tex.text = "In the midden, two combs have been found,"+ 
                    "which indicates that the people living there might have had some very nice hairdos.";
            }

        }
        if(model == "Østers")
        {
            if (danish)
            {
                headline.text = "Muslinger";
                tex.text = "Køkkenmøddingen består af store mængder af østersskaller fra de østers Ertebøllefolket har spist.\n" +
                "Der er dog ikke nok næring i østers til at man ville kunne nøjes med at spise dem.";
            }
            else
            {
                headline.text = "Oysters";
                tex.text = "The midden consisted largely of oyster shells from the oysters the people of Ertebølle ate."+
                    "However, this wasn’t the only thing they ate, since oysters do not contain a lot of nourishment.";
            }
        }
        if(model == "Fisk")
        {
            if (danish)
            {
                headline.text = "Fisk";
                tex.text = "I møddingen har man fundet fiskekroge. Man har fundet rigtig mange fiskeben fra ål." +
                " Ål var en populær fisk i Ertebølletiden, da det er en meget fedtholdig fisk.";
            }
            else
            {
                headline.text = "Fish";
                tex.text = "Fish hooks have been found in the midden, along with a lot of fishbones from eels." +
                "Eels were very popular fish since they contain a lot of fat.";
            }
        }
        if(model == "Hund")
        {
            if (danish)
            {
                headline.text = "Hunde";
                tex.text = "Hunde blev brugt til at gå på jagt og de var også de eneste tamme dyr man havde i Ertebølletiden. \n" +
                "Der er fundet knogler og ekskrementer i køkkenmøddingen fra hunde.";
            }
            else
            {
                headline.text = "Dogs";
                tex.text = "Dogs were used for hunting and were the only tame animals people had in the Ertebølle age.\n" +
                "Bones and faeces from dogs have been found at the midden.";
            }
        }
        if(model == "Skelet")
        {
            if (danish)
            {
                headline.text = "Skeletter";
                tex.text = "Der er blevet fundet et helt skelet i møddingen og mange andre menneskeknogler, "+ 
                    "hvilket viser at mødding også blev brugt som gravplads.";
            }
            else
            {
                headline.text = "Skeletons";
                tex.text = "A whole skeleton was found at the midden as well as many other human bones"+ 
                    "which indicates that the midden was also used to bury bodies.";
            }
        }
        if(model == "Hasselnød")
        {
            if (danish)
            {
                headline.text = "Skovens frugt";//eventuelt "Skovens mad"
                tex.text = "Ertebøllefolket har samlet spiselige planter i urskoven. " +
                    "I møddingen har man fundet knækkede nøddeskaller hvilket viser," +
                    "at hasselnødder var en del af de planter man spiste.";
            }
            else
            {
                headline.text = "Fruits";
                tex.text = "The Ertebølle people gathered edible plants in the primeval forest. "+ 
                    "Broken hazelnut shells have been found in the midden which shows that hazelnuts were among the plants they ate.";
            }
        }
        if(model == "Dyr")
        {
            if (danish)
            {
                headline.text = "Jagt";
                tex.text = "Ud over at fiske, levede man også af at jage vildt i skoven og resterne af fangsten blev også smidt i møddingen.";
            }
            else
            {
                headline.text = "Hunting";
                tex.text = "Aside from fishing, the Ertebølle people also hunted animals in the primeval forest."+ 
                    "The parts that could not be used from the animal was thrown in the midden.";
            }
        }
        if(model == "Tværpil")
        {
            if (danish)
            {
                headline.text = "Pile";
                tex.text = "Ertebølletidens tværpile var formet så de har en bred skærende æg. "+ 
                    "Pilen forårsager stor skade på dyrene, som forbløder hurtigt inden de når at løbe væk.";
            }
            else
            {
                headline.text = "Arrows";
                tex.text = "The arrows from the Ertebølle period were shaped to have a wide edge. "+ 
                    "The arrow caused great damage on the animal which would bleed to death before it could run away.";
            }
        }
        if(model == "Havet")
        {
            if (danish)
            {
                headline.text = "Kystlinjen";
                tex.text = "I Ertebølletiden var kystlinjen meget højere oppe på land og her så derfor meget anderledes ud. " +
                    "Ude i vandet var der store østers- og muslingebanker.";
            }
            else
            {
                headline.text = "Shoreline";
                tex.text = "In the Ertebølle period the shoreline was further up on land than it is now. "+ 
                    "The sea contained large clusters of oysters and mussels.";
            }
        }
    }
}
