using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRotation : MonoBehaviour {
    float speed;

	void Start () {
        speed = 15F;
        gameObject.transform.Rotate(Vector3.up, Time.deltaTime * speed);
	}

    private void LateUpdate()
    {
        gameObject.transform.Rotate(Vector3.up, Time.deltaTime * speed);
    }
}
