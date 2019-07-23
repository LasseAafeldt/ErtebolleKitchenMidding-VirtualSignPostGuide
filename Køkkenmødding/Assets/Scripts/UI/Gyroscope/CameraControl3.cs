using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl3 : MonoBehaviour
{
    float driftCorrection = 5f;

    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rot;
    private Quaternion previousAtt;

    // Use this for initialization
    void Start()
    {
        cameraContainer = new GameObject("Camera Containter");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);
        gyroEnabled = EnableGyro();
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        try { previousAtt = gyro.attitude; }
        catch { }
        Vector3 test = new Vector3(0.1f, 0.2f, 0.3f);
        Debug.Log("length = " + test.magnitude);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gyroEnabled)
        {
            Quaternion currentAtt = gyro.attitude;
            //Debug.Log("Rot rate = "+ gyro.rotationRateUnbiased);
            if (Quaternion.Angle(currentAtt, previousAtt) > driftCorrection * Time.deltaTime && gyro.rotationRateUnbiased.magnitude > 0.3f)
            {
                Quaternion tempNew = currentAtt * rot;
                Quaternion tempOld = previousAtt * rot;
                Quaternion targetTranslation = Quaternion.Inverse(tempOld) * tempNew;
                Quaternion targetRot = transform.localRotation * targetTranslation;
                transform.localRotation = targetRot;
            }



            previousAtt = gyro.attitude;
        }
    }
    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            //cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            cameraContainer.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            rot = new Quaternion(0, 0, 1, 0);

            return true;
        }
        return false;
    }

}