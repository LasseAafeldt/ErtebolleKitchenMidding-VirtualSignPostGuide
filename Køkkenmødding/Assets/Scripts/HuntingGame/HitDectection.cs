using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDectection : MonoBehaviour {
    public static bool collision = false;
    public static bool animalDoStuff = false;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Animal"))
        {
            Debug.Log("Hit!"); // do something when hitting the animal
            // use animalDoStuff to stop the arrow shooting here.
            animalDoStuff = true;
        }
        else
        {
            Debug.Log("Miss!"); // do something when missing the animal
        }
        collision = true;
        Destroy(gameObject.GetComponent<Rigidbody>()); // makes arrow stick to whatever is hit
        //StartCoroutine(destroyArrow(ShootArrow.arrowDead)); // destroys arrow clone after x seconds
    }

    IEnumerator destroyArrow(int x)
    {
        yield return new WaitForSeconds(x);
        //Debug.Log(gameObject);
        Destroy(gameObject);
        HuntingHandler.pil.SetActive(true);
        collision = false;
    }
}
