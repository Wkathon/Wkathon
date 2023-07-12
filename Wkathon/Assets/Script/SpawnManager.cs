using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private int maxCount;
    private int customerCount;
    public Transform[] spawnPoints;
    [SerializeField]
    private GameObject customer;
    [SerializeField]
    private float spawnTime;
    private float currTime;

    private static SpawnManager _instace;
    private void Start()
    {
        _instace = this;
    }
    void Update()
    {
        
        if (currTime >= spawnTime && maxCount > customerCount)
        {
            int rand = Random.Range(0, 2);
            SpawnCustomer(rand);
        }
        currTime += Time.deltaTime;
    }
    private void SpawnCustomer(int pointNum)
    {
        currTime = 0;
        customerCount++;
        Instantiate(customer, spawnPoints[pointNum]).GetComponent<CustomerControl>().spawnManager = this;
    }
}
