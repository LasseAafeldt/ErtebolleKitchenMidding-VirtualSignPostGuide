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
    private Vector3 pos;
    private List<Vector3> spawnPoints;
    private int childCount;

	// Use this for initialization
	void Start () {
        kills = 0;
        currentAnimals = 0;
        childCount = (int) GameObject.Find("SpawnPoints").transform.childCount;
        spawnPoints = new List<Vector3>();
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
        GameObject deerClone = Instantiate(prefab, chooseSpawn(), gameObject.transform.rotation); //do something about the toration
        ++currentAnimals;
        Debug.Log("animals: " + currentAnimals);

    }
    private Vector3 chooseSpawn()
    {
        pos = spawnPoints[Random.Range((int)1, childCount)];
        Debug.Log(Random.Range((int)1, childCount));
        return pos;
    }
    private void add2List()
    {
        for(int i = 0; i <= GameObject.Find("SpawnPoints").transform.childCount - 1; i++)
        {
            spawnPoints.Add(GameObject.Find("SpawnPoints").transform.GetChild(i).position);
        }
    }
}
