using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class readLogs : MonoBehaviour {
	private string myLog;
	private StreamReader reader;
	private string all;

	// Use this for initialization
	/*void Start () {
		foreach (string file in System.IO.Directory.GetFiles(Application.persistentDataPath + "/Data/")) {
			/*string pathfinder = System.IO.Path.GetFullPath();
			using (StreamReader reader = pathfinder) {
				all = all + reader.ReadToEnd();
			}*/
		}

	}*/
	
	// Update is called once per frame
	void Update () {
		Debug.Log(all);

	}
}
