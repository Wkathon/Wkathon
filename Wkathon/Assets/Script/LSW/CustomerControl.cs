using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerControl : MonoBehaviour
{
    private GameObject customer;
    private bool isLeft;

    private void Start()
    {
        //if (customer.transform.position)
        //{

     //   }
      //  else
       // {

     //   }
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
       
    }
    private void RightWalk()
    {

    }
}
