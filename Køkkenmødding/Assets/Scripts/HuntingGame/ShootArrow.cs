using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootArrow : MonoBehaviour {

    private Transform target;
    public float speed;
    public Camera cam;

    Vector3 dis;
    Vector3 dir;
    Vector3 screenCenter = new Vector3(0.5f, 0.5f, 0.0f);

    void Start () {
        target = new GameObject().transform;
        
	}
	
	
	void FixedUpdate () {
        if (Input.GetMouseButtonDown(0) && HuntingHandler.tutorial.activeInHierarchy == false)
        {
            setTarget();
            //dir = new Vector3(0, 0, 10*speed);
            dis = target.position - transform.position; //use something like screen2world position instead of target if we wanna make it better.
            dir = (dis / dis.magnitude) * speed;
            transform.GetComponent<Rigidbody>().AddForce(dir, ForceMode.Impulse);
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
}
