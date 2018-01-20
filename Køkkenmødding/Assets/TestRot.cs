
using UnityEngine;

public class TestRot : MonoBehaviour
{
    public float speed = 15;
    public float driftThreshold;
    Quaternion lastRotation;
    float angularDifferenceBetweenLastRotationAndCurrentRotation = 0;

    void Start()
    {
        gameObject.transform.Rotate(Vector3.up, Time.deltaTime * speed);
    }
    private void Update()
    {
        angularDifference(lastRotation, transform.rotation);
        driftHandler(driftThreshold);
        GameObject.Find("tester").transform.Rotate(Vector3.up, Time.deltaTime * speed);
    }

    private void LateUpdate()
    {        
        lastRotation = gameObject.transform.rotation;
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
}
