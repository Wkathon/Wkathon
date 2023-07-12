using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float breakedTime = 3600;

    public float BreakedTime;


    private void Update()
    {
        BreakedTime = breakedTime - Time.time;
    }
}
