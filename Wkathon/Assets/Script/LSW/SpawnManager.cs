using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    [SerializeField]
    private GameObject customer;
    [SerializeField]
    private float spawnTime;
    private float currTime;
    void Update()
    {
        
        if (currTime >= spawnTime)
        {
            int rand = Random.Range(0, 2);
            SpawnCustomer(rand);
        }
        currTime += Time.deltaTime;
    }
    private void SpawnCustomer(int pointNum)
    {
        currTime = 0;
        Instantiate(customer, spawnPoints[pointNum]);
    }
}
