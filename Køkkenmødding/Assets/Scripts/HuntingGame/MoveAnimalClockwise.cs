using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimalClockwise : MonoBehaviour {

    public float speed;

    private float dir;
    private Quaternion rot;
    CanvasGroup end;

	void Start () {
        dir = Mathf.Atan2(transform.position.x, transform.position.z); //angle in randians
        transform.rotation = Quaternion.AngleAxis(dir * Mathf.Rad2Deg, Vector3.up);
        end = end = GameObject.Find("EndOfGame").GetComponent<CanvasGroup>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (HitDectection.animalDoStuff == false && HuntingHandler.tutorial.activeInHierarchy == false && end.alpha == 0)
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
