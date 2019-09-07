using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour {

	public Material mat1;
	public Material mat2;
	private Renderer rend;
	private GameObject obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Touch touch = Input.touches[0];
		Ray touchRay = Camera.main.ScreenPointToRay(touch.position);
		RaycastHit[] hits = Physics.RaycastAll(touchRay);
		foreach( RaycastHit hit in hits ) { //change it so it only hits one object instead of several
			print("touching object " + hit.collider.name);
			if (hit.collider.material != mat1) {
				obj = hit.collider.gameObject;
				rend = obj.GetComponent<Renderer>();
				rend.material = mat1;
				/*rend = GameObject.Find (nameHolder).GetComponents<Renderer>;
				rend.sharedMaterial = mat1;*/
			} else {
				obj = hit.collider.gameObject;
				rend = obj.GetComponent<Renderer>();
				rend.material = mat2;
				/*var nameHolder = hit.collider.name;
				rend = GameObject.Find (nameHolder).GetComponents<Renderer>;
				rend.sharedMaterial = mat2; */
			}
			//Destroy (hit.transform.gameObject);
		}

	}
}
