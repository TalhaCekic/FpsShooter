using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerEnemy : MonoBehaviour
{
    public GameObject enemy;
    Vector3 spawnPoint;
    private float delay = 15;
    public bool stopSpawning = false;
    public float spawnTime;
    public void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, delay);
    }

  public void SpawnObject()
    {
        Instantiate(enemy,transform.position,transform.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}


