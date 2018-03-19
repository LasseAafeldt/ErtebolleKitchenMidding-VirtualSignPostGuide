using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    Quaternion driftRotation;
    Quaternion newRot;
    Quaternion oldRot;
    Quaternion actualRot;
    private bool conRot = false;

    // Use this for initialization
    void Start()
    {
        cameraContainer = new GameObject("Camera Containter");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);
        gyroEnabled = EnableGyro();
		newRot = gyro.attitude * rot;
		oldRot = newRot;

        /*if (!EnableGyro())
        {
            show the UI element here
            Toast.Create("", "No Gyroscope in device");
            activeGyro.Show();
        }*/
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        first = true;
        wasCalled = false;
    }

    // Update is called once per frame
	void Update()
    {
		//Debug.Log ("camconfig active = "+!HierarchyHandler.camConfig);
        if (gyroEnabled)
        {
            //StartCoroutine(driftDetermination());
            //transform.localRotation = gyro.attitude * rot * Quaternion.Inverse(previousRotation);
            Quaternion gyroPlusRot = gyro.attitude * rot;
            if(SceneManager.GetActiveScene().name == "Midding")
            {
                //StartCoroutine(continousRotation());
				//continousRotation();
                //transform.localEulerAngles = actualRot.eulerAngles + driftRotation.eulerAngles;
				//transform.localRotation = (transform.localRotation * Quaternion.Inverse(rot))
				//	* actualRot * rot; //* Quaternion.Inverse(driftRotation) * rot;
				//transform.localRotation = gyro.attitude;
				oldRot = newRot;
				newRot = gyro.attitude;
				//transform.localRotation = transform.localRotation * Quaternion.Inverse(oldRot) * newRot;
				//transform.localRotation = newRot * Quaternion.Inverse(oldRot) * transform.localRotation;
				transform.localRotation = newRot * rot;
            }
            if (SceneManager.GetActiveScene().name == "HuntingGame")
            {
                //transform.localEulerAngles = gyroPlusRot.eulerAngles + driftRotation.eulerAngles;
                /*if(conRot == true)
                {
                    StopCoroutine(continousRotation());
                    conRot = false;
                }*/
            }

        }
    }

    private bool EnableGyro()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;

            //cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
			//rot = Quaternion.Euler(0f, 0f, 180f);
			cameraContainer.transform.rotation = Quaternion.Euler(270f, 0f, 0f)*Quaternion.Euler(0f, 0f, 180f);
			rot = Quaternion.Euler(0f, 0f, 0f);

            return true;
        }
        return false;
    }

    IEnumerator driftDetermination()
    {
        wasCalled = true;
        if(currentRotation != null)
        {
            oldRotation = currentRotation;
        }
        else
        {
			oldRotation = gyro.attitude;
        }
        yield return 0;
		currentRotation = gyro.attitude;
        angle = Quaternion.Angle(oldRotation, currentRotation);
        if(angle <= driftThreshold)
        {
            drift = true;
            //adding drift into driftRotation veriable continously
            //driftRotation.eulerAngles += oldRotation.eulerAngles - currentRotation.eulerAngles;
            //driftRotation = (oldRotation * currentRotation) * driftRotation;
        }
        else if(angle > driftThreshold)
        {
            drift = false;
        }
		Debug.Log (drift);
        wasCalled = false;
    }

    //IEnumerator continousRotation()
	void continousRotation()
    {
        conRot = true;

        if(SceneManager.GetActiveScene().name == "Midding" && !HierarchyHandler.camConfig)
        {
			oldRot = newRot;
			newRot = gyro.attitude;

            //actualRot.eulerAngles = oldRotation.eulerAngles - newRot.eulerAngles; 
			actualRot =  newRot * Quaternion.Inverse(oldRot);
			Debug.Log ("actul rotation =" + actualRot);
            
            //yield return 0;
        }
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
