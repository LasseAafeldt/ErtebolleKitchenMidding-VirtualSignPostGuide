using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HuntingInfo : MonoBehaviour {
    public Text tex;
	// Use this for initialization
	void Start () {
        if (ChooseLanguage.language == 0)//Danish
        {
            tex.text = "I skoven kunne man jage Kronhjorte og andet vildt. "+
                "Man bragte fangsten hen til møddingen hvor den blev tilbredt og de ubrugelige dele blev smidt i møddingen. \n"
                //+"Man levede også af at jage vildt i skoven og resterne af fangsten blev også smidt i møddingen." +
                +"\n"+
                "Ertebølletidens tværpile var formet så de har en bred skærende æg.\n" + 
                "Pilen forårsager stor skade på dyrene, som forbløder hurtigt inden de når at løbe væk."
                ;
        }
        if(ChooseLanguage.language == 1)//English
        {
            tex.text = "In the forrest the hunters found primarily Deer to hunt. \n"+
                "They would move the catch to the midding where is was prepared and the unusable parts were thrown in the midding. \n"+
                "\n"+
                "The arrows from the ertebølle period were shaped to have a wide edge.\n" +
                "The arrow caused great damage on the animal which would bleed to death before it could run away."
                ;
        }
            
	}
}
