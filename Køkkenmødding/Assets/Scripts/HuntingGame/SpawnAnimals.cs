using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnAnimals : MonoBehaviour {

    public int animalsInScene;
    //public float rangeMin;
    //public float rangeMax;

    public static int currentAnimals;
    public GameObject prefab;
    public static int kills;
    private Transform pos;
    private List<Transform> spawnPoints;
    private int childCount;

	// Use this for initialization
	void Start () {
        kills = 0;
        currentAnimals = 0;
        childCount = (int) GameObject.Find("SpawnPoints").transform.childCount;
        spawnPoints = new List<Transform>();
        add2List();
	}
	
	// Update is called once per frame
	void Update () {
		if(animalsInScene > currentAnimals)
        {
            spawnAnimal();
        }
	}
    public void spawnAnimal()
    {
        GameObject deerClone = Instantiate(prefab, chooseSpawn().position, chooseSpawn().transform.rotation); //do something about the toration
        ++currentAnimals;
        //Debug.Log("animals: " + currentAnimals);


    }
    private Transform chooseSpawn()
    {
        pos = spawnPoints[Random.Range((int)1, childCount)];
        //Debug.Log("spawn point " + pos);
        return pos;
    }
    private void add2List()
    {
        for(int i = 0; i <= GameObject.Find("SpawnPoints").transform.childCount - 1; i++)
        {
            spawnPoints.Add(GameObject.Find("SpawnPoints").transform.GetChild(i));
        }
    }
}
