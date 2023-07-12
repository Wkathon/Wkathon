using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CustomerControl : MonoBehaviour
{
    private bool isLeft;
    [SerializeField]
    private float speed;

    public SpawnManager spawnManager;

    private void Start()
    {
        if (transform.position == spawnManager.spawnPoints[0].position)
        {
            isLeft = false;
        }
        else
        {
            isLeft = true; 
        }
    }
     void Update()
    {
        if (isLeft)
        {
            RightWalk();
        }
        else
        {
            LeftWalk();
        }
    }
    private void LeftWalk()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    private void RightWalk()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
