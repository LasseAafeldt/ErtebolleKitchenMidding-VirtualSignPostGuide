using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Logging : MonoBehaviour {
	/*
	 * Amount of audio played
	 * Amount of time app is open
	 * Time spent on game
	 * View direction
	 * all touch related events and where they are touching
	 */
	// Use this for initialization
	private string headers = "Touch;AppOnTime;AudioPlays;GameOnTime;TouchPositionX;TouchPositionY;CameraRotationX;CameraRotationY;CameraRotationZ;CameraRotationW";
	private StreamWriter writer;
	private string directory;
	private string currentEntry;
	private string fileName;
	private string sep = ";";

	private float appOn = 0.0f; //How long the app has been running
	private int numofAud = 0; //times audio is player
	private Camera cam; //finds the camera
	private Quaternion camRot; //used for getting the rotation of the camera
	private float gameTime; //how long the minigame is played
	private int i = 0; //counter
	private Vector2 posi; //position for the touch

	void Start () {
		cam = Camera.main; //finds the camera
		directory = Application.persistentDataPath + "/Data/";

		if (!Directory.Exists(directory)){
			Directory.CreateDirectory(directory);
		}
		newLog ();
	}

	public void newLog()
	{
		fileName = System.DateTime.Now.ToString () + " midden.txt";
		fileName = fileName.Replace ('/', '-');
		fileName = fileName.Replace (':', '-');

		using (StreamWriter writer = File.AppendText (directory + fileName)) {
			writer.WriteLine (headers); //The first line that shows what each coloumn is
		}
	}
		
	// Update is called once per frame

	void Update () {
		newEntry ();
	}
	public void newEntry () {
		/*	appOn = Time.time;
		numofAud = audioHandler.GetComponent<AudioHandler> ().audioPlayed;
		gameTime = PlayerPrefs.GetFloat ("game Time", 0); */

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
		//if (Input.GetMouseButtonDown(0))
		{
			appOn = Time.time;
			numofAud = AudioHandler.audioPlayed;
			gameTime = PlayerPrefs.GetFloat ("game Time", 0.0f);
			posi = Input.GetTouch(0).position;
			//posi = Input.mousePosition;
			camRot = cam.transform.rotation;
			currentEntry = "touch begin " + appOn + sep + numofAud + sep + gameTime + sep 
				+ posi.x + sep + posi.y + sep 
				+ camRot.x + sep + camRot.y + sep + camRot.z + sep + camRot.w + sep + OpenModelInfo.model;
			using (StreamWriter writer = File.AppendText (directory + fileName)) {
				writer.WriteLine (currentEntry);
			}
		}
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
		{
			appOn = Time.time;
			numofAud = AudioHandler.audioPlayed;
			gameTime = PlayerPrefs.GetFloat ("game Time", 0.0f);
			posi = Input.GetTouch (0).position;
			camRot = cam.transform.rotation;
			currentEntry = "touch end " + appOn + sep + numofAud + sep + gameTime + sep 
				+ posi.x + sep + posi.y + sep 
				+ camRot.x + sep + camRot.y + sep + camRot.z + sep + camRot.w + sep + OpenModelInfo.model;
			using (StreamWriter writer = File.AppendText (directory + fileName)) {
				writer.WriteLine (currentEntry);
			}
		}

	}
}
