using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimal : MonoBehaviour {


    public float minMoveDistance;
    public float maxMoveDistance;
    public float speed;

    private Vector3 targetPos;
    private Vector3 dir;

	// Use this for initialization
	void Start () {
        dir = Random.insideUnitCircle;
        targetPos = new Vector3(dir.x * Random.Range(minMoveDistance, maxMoveDistance), transform.position.y, dir.y * Random.Range(minMoveDistance, maxMoveDistance));
        targetPos = transform.position - targetPos;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if(HuntingHandler.tutorial.activeInHierarchy == false)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
        }
	}

}
