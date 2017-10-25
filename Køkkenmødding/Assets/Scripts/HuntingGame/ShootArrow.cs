using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootArrow : MonoBehaviour {

    public float speed;
    public Camera cam;
    public GameObject prefab;
    //public static int arrowDead = 3;

    //private Transform target;
    //private Vector3 dis;
    private Vector3 dir;
    //private Vector3 tar;
    //private Vector3 screenCenter = new Vector3(0.5f, 0.5f, 0.0f);

    void Start () {
        //target = new GameObject().transform;// This creates New Game Object every time the mouse is clicked............
        //Debug.Log("Creating new gameobject target");
        cam = Camera.main;
	}
	
	
	void FixedUpdate () {
        if (Input.GetMouseButtonDown(0) && HuntingHandler.tutorial.activeInHierarchy == false && HuntingHandler.pil.activeInHierarchy == true)
        {        
            GameObject arrowClone = Instantiate(prefab, transform.position, transform.GetChild(0).transform.rotation);

            arrowClone.transform.localScale = new Vector3(0.2F, 0.2F, 0.2F); //if we change size of arrow fbx we need to change here aswell

            HuntingHandler.pil.SetActive(false); //make the arrow at the camera dissapear
            dir = transform.TransformDirection(0, 0, 1* speed);
            arrowClone.transform.GetComponent<Rigidbody>().AddForce(dir, ForceMode.Impulse);
            //StartCoroutine(hitTimer(arrowDead));
        }
        if(HuntingHandler.pil.activeInHierarchy == false && HitDectection.animalDoStuff == false)
        {
            newArrow();
        }
	}
    void newArrow()
    {
        StartCoroutine(waitASec());
    }

    IEnumerator waitASec()
    {
        yield return new WaitForSeconds(1);

        Debug.Log(HitDectection.animalDoStuff);
        if (Input.GetMouseButtonDown(0) && HitDectection.animalDoStuff == false)
        {

            Destroy(GameObject.Find("Arrow(Clone)"));
            HuntingHandler.pil.SetActive(true);
        }
    }
}
