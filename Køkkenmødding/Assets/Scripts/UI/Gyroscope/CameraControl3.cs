using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl3 : MonoBehaviour {

	private bool gyroEnabled;
	private Gyroscope gyro;

	private GameObject cameraContainer;
	private Quaternion rot;
    private Quaternion gyroTranslation;
    private Quaternion previousGyroAttitude;

	// Use this for initialization
	void Start () {
		cameraContainer = new GameObject ("Camera Containter");
		cameraContainer.transform.position = transform.position;
		transform.SetParent (cameraContainer.transform);
		gyroEnabled = EnableGyro ();
		Screen.orientation = ScreenOrientation.LandscapeLeft;
        previousGyroAttitude = gyro.attitude;
	}

	// Update is called once per frame
	void Update () {
		if (gyroEnabled) {
            //transform.localRotation = gyro.attitude * rot;
            Quaternion currentGyroAttitude = gyro.attitude;

            gyroTranslation = currentGyroAttitude * Quaternion.Inverse(previousGyroAttitude);


            transform.localRotation = transform.localRotation * gyroTranslation;
            previousGyroAttitude = gyro.attitude;
		}
	}
	private bool EnableGyro(){
		if (SystemInfo.supportsGyroscope) {
			gyro = Input.gyro;
			gyro.enabled = true;

            //cameraContainer.transform.rotation = Quaternion.Euler (90f, 90f, 0f);
            cameraContainer.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            rot = new Quaternion (0, 0, 1, 0);

            
			return true;
		}
		return false;
	}

}
