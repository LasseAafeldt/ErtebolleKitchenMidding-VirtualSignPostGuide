using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelerometer : MonoBehaviour{

    public float AccelerometerUpdateInterval = 1.0f / 100.0f;
    public float LowPassKernelWidthInSeconds = 0.001f;
    public Vector3 lowPassValue = Vector3.zero;
    float xValue;
    float xValueMinMax = 5.0f;

    float yValue;
    float yValueMinMax = 5.0f;

    float cameraSpeed = 20.0f;// Greater the lower speed
    Vector3 accelometerSmoothValue;
    void Start()
    {

    }

    void Update()
    {
        //lowpass();
        cameraRotationAccelerometer();
    }

    void cameraRotationAccelerometer()
    {
        //Set X Min Max
        /*if (xValue < -xValueMinMax)
            xValue = -xValueMinMax;

        if (xValue > xValueMinMax)
            xValue = xValueMinMax;

        //Set Y Min Max
        if (yValue < -yValueMinMax)
            yValue = -yValueMinMax;

        if (yValue > yValueMinMax)
            yValue = yValueMinMax; */

        accelometerSmoothValue = lowpass();

        xValue += accelometerSmoothValue.x;
        yValue += accelometerSmoothValue.y;

        transform.localRotation = new Quaternion(yValue, xValue, 0, cameraSpeed);
    }

    //Smooth Accelerometer
    Vector3 lowpass()
    {
        float LowPassFilterFactor = AccelerometerUpdateInterval / LowPassKernelWidthInSeconds;//tweakable
        lowPassValue = Vector3.Lerp(lowPassValue, Input.acceleration, LowPassFilterFactor);
        return lowPassValue;
    }
}
