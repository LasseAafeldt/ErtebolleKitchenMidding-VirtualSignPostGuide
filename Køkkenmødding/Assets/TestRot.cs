
using UnityEngine;
using System.Collections;

public class TestRot : MonoBehaviour
{
    public float speed = 15;
    public float driftThreshold;
    Quaternion lastRotation;
    float angularDifferenceBetweenLastRotationAndCurrentRotation = 0;
    private bool wasCalled = false;
    private bool first = true;
    private bool drift = false;
    private float angle;
    Quaternion oldRotation;
    Quaternion currentRotation;
    Quaternion previousRotation;
    public float threshold;
    public float timeInterval = 0;

    void Start()
    {
        //gameObject.transform.Rotate(Vector3.up, Time.deltaTime * speed);
        
    }
    private void Update()
    {
        //angularDifference(lastRotation, transform.rotation);
        //driftHandler(driftThreshold);
        if(wasCalled == false)
        {
            //StartCoroutine(differenceInRotation(tim, transform));
            //StartCoroutine(spawn(tim));
            StartCoroutine(driftDetermination());
        }
        transform.Rotate(Vector3.up, Time.deltaTime * speed);
        //transform.localEulerAngles = previousRotation.eulerAngles;
        Debug.Log(previousRotation.eulerAngles);

    }

    private void LateUpdate()
    {        
        //lastRotation = gameObject.transform.rotation;
    }

    void angularDifference(Quaternion lastRot, Quaternion currentRot)
    {
        if(lastRot == null)
        {
            return; //doesn't do below if it doesn't have a last rotation
        }

        float angularDifferenceBetweenLastRotationAndCurrentRotation = Quaternion.Angle(lastRot, currentRot);
    }

    void driftHandler(float driftThreshold)
    {
        if(Mathf.Abs(angularDifferenceBetweenLastRotationAndCurrentRotation) >= driftThreshold)
        {
            //Debug.Log("Rotate back. please");
            gameObject.transform.Rotate(Vector3.up, Time.deltaTime * 15);
        }
    }

    IEnumerator driftDetermination()
    {
        wasCalled = true;
        oldRotation = transform.rotation;
        yield return new WaitForSeconds(timeInterval);
        currentRotation = transform.rotation;
        angle = Quaternion.Angle(oldRotation, currentRotation);
        if (angle <= driftThreshold)
        {
            drift = true;
            //previousRotation = oldRotation * Quaternion.Inverse(currentRotation);
            previousRotation.eulerAngles += oldRotation.eulerAngles - currentRotation.eulerAngles;
        }
        else if (angle > driftThreshold)
        {
            drift = false;
            previousRotation = new Quaternion(0, 0, 0, 0);
        }

        wasCalled = false;
    }

    /*IEnumerator differenceInRotation(float time, Transform rotatingObject)
    {
        wasCalled = true;
        //Vector3 previousRotation = rotatingObject.rotation.eulerAngles;
        oldRotation = rotatingObject.TransformPoint(rotationManager.transform.position.x, rotationManager.transform.position.y, rotationManager.transform.position.z);
        yield  return new WaitForSeconds(time);
        newPosition = rotatingObject.TransformPoint(rotationManager.transform.position.x, rotationManager.transform.position.y, rotationManager.transform.position.z);
        float dist = Vector3.Distance(newPosition, oldRotation);
        Debug.Log(dist);
        //Debug.Log(Vector3.Angle(oldRotation, newPosition));
        //Debug.Log(Vector3.Angle(rotatingObject.rotation.eulerAngles, previousRotation));
    }

    IEnumerator spawn(float time)
    {
        wasCalled = true;
        if(first == false)
        {
            OldMarker = Marker;
        }
        yield return new WaitForSeconds(time);
        Marker = Instantiate(marker, gameObject.transform.forward , transform.rotation);

        if(OldMarker!= null)
        {
            Debug.Log(Vector3.Angle(OldMarker.transform.position, Marker.transform.position));
            Destroy(OldMarker);
        }
        first = false;
        wasCalled = false;
    }

    IEnumerator angle(float time)
    {
        wasCalled = true;
        Quaternion old = transform.rotation;
        yield return new WaitForSeconds(time);
        Quaternion newrot = transform.rotation;

        Debug.Log(Quaternion.Angle(old, newrot));
        wasCalled = false;
    }*/
}
