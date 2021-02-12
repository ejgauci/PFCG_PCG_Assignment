using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    
    GameObject player;

    Vector3 spawnPlayerLocation;
    public List<Vector3> Locations = new List<Vector3>();
    int randomPos = 0;

    private void Start()
    {
        //locatons the target or player can spawn
        Locations.Add(new Vector3(25, 0, 25));  //1
        Locations.Add(new Vector3(-25, 0, 15));//2
        Locations.Add(new Vector3(25, 0, 15));//3
        Locations.Add(new Vector3(-25, 0, -5));//4
        Locations.Add(new Vector3(5, 0, -15));//5
        Locations.Add(new Vector3(25, 0, -15));//6
        Locations.Add(new Vector3(-25, 0, -25));//7
        Locations.Add(new Vector3(-15, 0, -25));//8

        randomPos = Random.Range(0, 7);

        SpawnPlayer();
        SpawnTarget();
    }

    public void SpawnPlayer()
    {


        spawnPlayerLocation = Locations[randomPos];

        player = Resources.Load("Prefabs/Pyramid") as GameObject;

        Instantiate(player, spawnPlayerLocation, Quaternion.identity);
        GameObject.Find("Pyramid(Clone)").AddComponent<PlayerController>();
        GameObject.Find("Pyramid(Clone)").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        GameObject.Find("Pyramid(Clone)").AddComponent<BoxCollider>().isTrigger = true;
    }


    
    public void SpawnTarget()
    {
        GameObject target = Resources.Load("Prefabs/Cube") as GameObject;

        Vector3 spawnEnemyLocation = Locations[Random.Range(0, Locations.Count - 1)];

        if (spawnEnemyLocation != spawnPlayerLocation)
        {
            Instantiate(target, spawnEnemyLocation, Quaternion.identity);
            GameObject.Find("Cube(Clone)").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            GameObject.Find("Cube(Clone)").AddComponent<BoxCollider>().isTrigger = true;
            GameObject.Find("Cube(Clone)").AddComponent<BoxCollider>().size = new Vector3(2,2,2);
        }
        else
        {
            SpawnTarget();
        }
    }
}
