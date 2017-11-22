using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimalClockwise : MonoBehaviour {

    public float speed;

    private float dir;
    private Quaternion rot;

	void Start () {
        dir = Mathf.Atan2(transform.position.x, transform.position.z); //angle in randians
        transform.rotation = Quaternion.AngleAxis(dir * Mathf.Rad2Deg, Vector3.up);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if(HitDectection.animalDoStuff == false && HuntingHandler.tutorial.activeInHierarchy == false && HuntingHandler.end.activeInHierarchy == false)
        {
            move();
        }
	}
    void move()
    {
        transform.RotateAround(Camera.main.transform.position, Vector3.up, speed * Time.deltaTime);
        dir = Mathf.Atan2(transform.position.x, transform.position.z) + 90; //angle in randians
        transform.rotation = Quaternion.AngleAxis(dir * Mathf.Rad2Deg, Vector3.up);
    }
}
