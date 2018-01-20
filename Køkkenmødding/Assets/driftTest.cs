using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driftTest : MonoBehaviour
{
    public float driftThreshold = 1;

    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rot;
    private Quaternion previousRotation;

    // Use this for initialization
    void Start()
    {
        cameraContainer = new GameObject("Camera Containter");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);
        gyroEnabled = EnableGyro();
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        if (gyroEnabled)
        {
            driftCalculation();
            transform.localRotation = gyro.attitude * rot;
        }
    }

    private void LateUpdate() // the actual drift correction
    {
        if (driftCalculation())
        {
            transform.localRotation = gyro.attitude * Quaternion.Inverse(rot);
        }
        else
        {
            previousRotation = transform.localRotation;
        }
    }
    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }
        return false;
    }

    bool driftCalculation() // the calculation of drift occurence
    {
        if(Mathf.Abs(Quaternion.Angle(previousRotation, transform.localRotation)) < driftThreshold)
        {
            return true;
        }

        return false;
    }

}
