using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTouch : MonoBehaviour {

	private Camera cam;
	private float xAngle = 0.0f;
	private float yAngle = 0.0f;
	private float xAngleTemp = 0.0f;
	private float yAngleTemp = 0.0f;
	private Vector3 secondPoint;
	private Vector3 firstPoint;

	// Use this for initialization
	void Start () {
		cam = Camera.main;
		xAngle = cam.transform.localRotation.x;
		yAngle = cam.transform.localRotation.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
		if (Input.GetTouch(0).phase == TouchPhase.Began)
		{
			firstPoint = Input.GetTouch (0).position;
			xAngleTemp = xAngle;
			yAngleTemp = yAngle;
		}
		if (Input.GetTouch (0).phase == TouchPhase.Moved) {
				secondPoint = Input.GetTouch (0).position;
				xAngle = xAngleTemp + (secondPoint.x - firstPoint.x) * 180.0f / Screen.width;
				yAngle = yAngleTemp + (secondPoint.y - firstPoint.y) * 90.0f / Screen.height;
				Quaternion vec = (Quaternion.Euler (yAngle, -xAngle, 0.0f));
				cam.transform.rotation = vec;
			}
		}
	}
}
