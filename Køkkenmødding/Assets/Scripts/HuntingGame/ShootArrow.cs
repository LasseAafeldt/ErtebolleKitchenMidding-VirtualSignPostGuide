using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootArrow : MonoBehaviour {

    private Transform target;
    public float speed;
    public Camera cam;
    public GameObject prefab;
    //public GameObject arrow;

    Vector3 dis;
    Vector3 dir;
    Vector3 screenCenter = new Vector3(0.5f, 0.5f, 0.0f);

    void Start () {
        target = new GameObject().transform;
        cam = Camera.main;
	}
	
	
	void FixedUpdate () {
        if (Input.GetMouseButtonDown(0) && HuntingHandler.tutorial.activeInHierarchy == false)
        {
            setTarget();
            //dir = new Vector3(0, 0, 10*speed);
            dis = target.position - transform.position; //use something like screen2world position instead of target if we wanna make it better.
            dir = (dis / dis.magnitude) * speed;


            GameObject arrowClone = Instantiate(prefab, transform.position, transform.rotation);
            //arrow.AddComponent<Rigidbody>();
            
            arrowClone.transform.GetComponent<Rigidbody>().AddForce(dir, ForceMode.Impulse);

            
            
            
        }
	}
    void setTarget()
    {
        
        RaycastHit hit;
        Ray ray = cam.ViewportPointToRay(screenCenter);

        if(Physics.Raycast(ray, out hit))
        {
            Debug.Log("I'm looking at " + hit.transform.name);
            target.position = hit.transform.position;
        }
        else
        {
            Debug.Log("im looking at nothing");
            target.position = GameObject.Find("MockPos").transform.position;
        }
    }

    Vector3 getTarget()
    {
        return target.position;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Animal"))
        {
            Debug.Log("Hit!"); // do something when hitting the animal
        }
        else
        {
            Debug.Log("Miss!"); // do something when missing the animal
        }
        Destroy(gameObject.GetComponent<Rigidbody>()); // makes arrow stick to whatever is hit
        StartCoroutine(destroyArrow(2)); // destroys arrow clone after x seconds
    }

    IEnumerator destroyArrow(int x)
    {
        yield return new WaitForSeconds(x);
        //Debug.Log(gameObject);
        Destroy(gameObject);
    }
}
