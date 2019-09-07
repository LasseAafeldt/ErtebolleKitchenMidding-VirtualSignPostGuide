using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Touch touch = Input.touches [0];
		Ray touchRay = Camera.main.ScreenPointToRay (touch.position);
		RaycastHit[] hits = Physics.RaycastAll (touchRay);
		foreach (RaycastHit hit in hits) {
			Scene scene = SceneManager.GetActiveScene ();
			Scene standard = SceneManager.GetSceneByName ("test");
			/*if (scene == standard) {
				SceneManager.LoadScene ("test");
			} else {
				SceneManager.LoadScene ("Test2");
			}*/
		}
		
	}
}
