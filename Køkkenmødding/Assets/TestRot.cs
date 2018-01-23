
using UnityEngine;
using System.Collections;

public class TestRot : MonoBehaviour
{
    public float speed = 15;
    public float driftThreshold;
    Quaternion lastRotation;
    float angularDifferenceBetweenLastRotationAndCurrentRotation = 0;
    public bool wasCalled = false;
    public bool first = true;
    Vector3 oldRotation;
    Vector3 newPosition;
    public GameObject rotationManager;
    public GameObject marker;
    GameObject Marker;
    GameObject OldMarker;
    public float tim = 2;

    void Start()
    {
        //gameObject.transform.Rotate(Vector3.up, Time.deltaTime * speed);
        
    }
    private void Update()
    {
        //angularDifference(lastRotation, transform.rotation);
        //driftHandler(driftThreshold);
        transform.Rotate(Vector3.up, Time.deltaTime * speed);
        if(wasCalled == false)
        {
            //StartCoroutine(differenceInRotation(tim, transform));
            StartCoroutine(spawn(tim));
        }
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

    IEnumerator differenceInRotation(float time, Transform rotatingObject)
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
}
