using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour {

    public int animalsInScene;
    public float rangeMin;
    public float rangeMax;

    public GameObject prefab;
    private Vector2 dir;
    private float dis;
    private Vector3 pos;
    private int currentAnimals;

	// Use this for initialization
	void Start () {
        currentAnimals = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(animalsInScene >= currentAnimals)
        {
            randomSpawn();
        }
	}

    void randomSpawn()
    {
        dir = Random.insideUnitCircle;
        dis = Random.Range(rangeMin, rangeMax);
        pos = new Vector3(dir.x * dis, 1, dir.y * dis);

        GameObject deerClone = Instantiate(prefab, pos, GameObject.Find("Animal_1").transform.rotation); //do something about the toration
        currentAnimals++;

        //maybe add a despawn timer? or despawn when traveled certain distance.
    }
}
