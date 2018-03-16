using UnityEngine;
using UnityEngine.UI;

public class DisableOptions : MonoBehaviour {

    public CanvasGroup optionCanvasGroup;
    public GameObject gyroCanvasObj;

    public void disable()
    {
        optionCanvasGroup.alpha = 0;
        optionCanvasGroup.interactable = false;
        optionCanvasGroup.blocksRaycasts = false;
    }

    public void enable()
    {
        optionCanvasGroup.alpha = 1;
        optionCanvasGroup.interactable = true;
        optionCanvasGroup.blocksRaycasts = true;
    }
}
