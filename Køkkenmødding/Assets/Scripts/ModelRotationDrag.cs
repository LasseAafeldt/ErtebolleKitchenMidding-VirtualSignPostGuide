using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRotationDrag : MonoBehaviour {

    float rotSpeed;
	void Start () {
        rotSpeed = 20;
	}

    private void OnMouseDrag() // shit is not working for some reason
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        Debug.Log("I have entered");

        GameObject.Find("ModelPosition").transform.Rotate(Vector3.up, -rotX);
        GameObject.Find("ModelPosition").transform.Rotate(Vector3.right, -rotY);
    }
}
