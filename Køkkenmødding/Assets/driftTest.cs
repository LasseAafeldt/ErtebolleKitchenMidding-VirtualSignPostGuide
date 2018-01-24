using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driftTest : MonoBehaviour
{
    public float driftThreshold = 1;

    public GameObject empty;
    public float timeInterval = 1;

    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rot;
    //private Quaternion previousRotation;
    private bool wasCalled = false;
    private bool first = true;
    private bool drift = false;
    private float angle;
    Quaternion oldRotation;
    Quaternion currentRotation;
    Quaternion previousRotation;

    // Use this for initialization
    void Start()
    {
        cameraContainer = new GameObject("Camera Containter");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);
        gyroEnabled = EnableGyro();
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        first = true;
        wasCalled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gyroEnabled)
        {
            StartCoroutine(driftDetermination());
            transform.localRotation = gyro.attitude * rot * Quaternion.Inverse(previousRotation);
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

    IEnumerator driftDetermination()
    {
        wasCalled = true;
        oldRotation = transform.rotation;
        yield return new WaitForSeconds(timeInterval);
        currentRotation = transform.rotation;
        angle = Quaternion.Angle(oldRotation, currentRotation);
        if(angle <= driftThreshold)
        {
            drift = true;
            previousRotation = oldRotation * Quaternion.Inverse(currentRotation);
        }
        else if(angle > driftThreshold)
        {
            drift = false;
            previousRotation = new Quaternion(0, 0, 0, 0);
        }

        wasCalled = false;
    }
    /*IEnumerator driftDetermination() //determines if there is drift and prints true if there is and false if there is not
    {
        wasCalled = true;
        if (first == false)
        {
            oldMarker = marker;
        }
        yield return new WaitForSeconds(0);
        marker = Instantiate(empty, gameObject.transform.forward, transform.rotation);

        if (oldMarker != null)
        {
            angle = Vector3.Angle(oldMarker.transform.position, marker.transform.position);
            if (angle <= driftThreshold)
            {
                drift = true;
            }
            else if(angle > driftThreshold)
            {
                drift = false;
            }
            Destroy(oldMarker);
        }
        Debug.Log(drift);
        first = false;
        wasCalled = false;
    }*/

}
