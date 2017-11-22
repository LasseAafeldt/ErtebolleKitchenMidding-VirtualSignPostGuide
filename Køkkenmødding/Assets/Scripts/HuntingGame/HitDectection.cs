using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDectection : MonoBehaviour {
    public static bool collision = false;
    public static bool animalDoStuff = false;
    public static bool hasHit = false;
    GameObject sound;
    private void Start()
    {
        sound = GameObject.Find("DeerSound");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Animal"))
        {
            Debug.Log("Hit!"); // do something when hitting the animal
            // use animalDoStuff to stop the arrow shooting here.
            //animalDoStuff = true;
            StartCoroutine(destroyAnimal(col));
            hasHit = true;
            SpawnAnimals.kills++;
        }
        else
        {
            Debug.Log("Miss!"); // do something when missing the animal
        }
        collision = true;
        transform.parent = col.transform;
        gameObject.GetComponent<Rigidbody>().isKinematic = true; // makes arrow stick to whatever is hit
    }
    IEnumerator destroyAnimal(Collision col)
    {
        animalDoStuff = true;
        sound.transform.position = col.transform.position;
        sound.GetComponent<AudioSource>().Play();
        //col.gameObject.GetComponent<AudioSource>().PlayOneShot(Resources.Load<AudioClip>("Audio/SFX/Deer 2"));
        yield return new WaitForSeconds(1.5F);
        Debug.Log(col.gameObject);
        Destroy(col.gameObject);
        SpawnAnimals.currentAnimals--;
        animalDoStuff = false;
    }
}
