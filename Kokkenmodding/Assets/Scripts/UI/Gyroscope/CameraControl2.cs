using UnityEngine;
using System.Collections;

public class CameraControl2 : MonoBehaviour {

	//private Quaternion origin = Quaternion.identity;

	void Start () {
		Input.gyro.enabled = true;
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		//origin = Input.gyro.attitude;
	}
	
	// Update is called once per frame
	void Update () {
		GyroModifyCamera ();
	}

	void GyroModifyCamera(){
		/*if (Input.touchCount > 0 || origin == Quaternion.identity) {
			origin = Input.gyro.attitude;
		}*/
		//transform.localRotation = Quaternion.Inverse (origin) * GyroToUnity (Input.gyro.attitude);
		transform.localRotation = GyroToUnity (Input.gyro.attitude);
	 	//Quaternion.AngleAxis(270, Vector3.forward);
		transform.Rotate (Vector3.forward*270);
		transform.Rotate (Vector3.right * 90);
		Debug.Log (Input.gyro.attitude);
		Debug.Log (transform.rotation);
	}

	private static Quaternion GyroToUnity(Quaternion q){
		return new Quaternion (q.x, -q.y, -q.z, -q.w);
	}

}
