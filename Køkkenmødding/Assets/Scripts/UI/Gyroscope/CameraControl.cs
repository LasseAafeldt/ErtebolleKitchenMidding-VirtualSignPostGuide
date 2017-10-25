using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{

	void Start ()
	{
		Input.gyro.enabled = true;
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	void Update ()
	{
		transform.Rotate (0.0f, -Input.gyro.rotationRateUnbiased.y, 0.0f); //z-axis and x-axis locked to avoid drifting.
		//transform.rotation = Input.gyro.attitude;
		if (Input.touchCount > 0) {
			for (int i = 0; i < 1; i++) {
				Vector2 pos = Input.GetTouch (0).position;
				Debug.Log (pos.x);
				Debug.Log (pos.y);
			}
		}
	}
}