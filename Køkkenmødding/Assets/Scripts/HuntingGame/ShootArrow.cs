using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShootArrow : MonoBehaviour {

    public float speed;
    public Camera cam;
    public GameObject prefab;
    public static int arrowsShot;

    private Vector3 dir;
    int arrowAmount;
    CanvasGroup end;

    void Start () {
        cam = Camera.main;
        arrowAmount = 60;
        //updateQuiver();
        end = GameObject.Find("EndOfGame").GetComponent<CanvasGroup>();
	}
	
	
	void FixedUpdate () {
        if (Input.GetMouseButtonDown(0) && HuntingHandler.tutorial.activeInHierarchy == false && HuntingHandler.pil.activeInHierarchy == true && arrowsShot < arrowAmount && end.alpha == 0)
        {        
            GameObject arrowClone = Instantiate(prefab, transform.position, transform.GetChild(0).transform.rotation);

            arrowClone.transform.localScale = new Vector3(0.2F, 0.2F, 0.2F); //if we change size of arrow fbx we need to change here aswell

            HuntingHandler.pil.SetActive(false); //make the arrow at the camera dissapear
            dir = transform.TransformDirection(0, 0, 1* speed);
            arrowClone.transform.GetComponent<Rigidbody>().AddForce(dir, ForceMode.Impulse);
            arrowsShot++;
            Debug.Log("Arrows fired = " + arrowsShot);
            Debug.Log("max arrows = " + arrowAmount);
            //updateQuiver();
        }
        if(HuntingHandler.pil.activeInHierarchy == false && HitDectection.animalDoStuff == false)
        {
            newArrow();
        }
	}
    void newArrow()
    {
        StartCoroutine(waitASec(0F));
    }

    IEnumerator waitASec(float x)
    {
        yield return new WaitForSeconds(x);

        if (Input.GetMouseButtonDown(0) && HitDectection.animalDoStuff == false)
        {

            Destroy(GameObject.Find("Arrow(Clone)"));
            HuntingHandler.pil.SetActive(true);
        }
    }

    void updateQuiver()
    {
        int arrowsLeft = arrowAmount - arrowsShot;
        GameObject.Find("ArrowsLeft").GetComponent<Text>().text = arrowsLeft.ToString();
    }
}
