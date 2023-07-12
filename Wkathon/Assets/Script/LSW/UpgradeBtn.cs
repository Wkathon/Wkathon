using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBtn : MonoBehaviour
{

    private int cost_a;
    private int cost_b;
    private int cost_c;
    private int cost_d;
    Money money;

    
    public GameObject ugradeBt1;
    public GameObject ugradeBt2;
    public GameObject ugradeBt3;
    public GameObject ugradeBt4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        money = FindObjectOfType<Money>();
        cost_a = GameObject.Find("1stConcertHall").GetComponent<Departments>().cost;

        if (cost_a <= money.money)
        {
            ugradeBt1.SetActive(true);
        } else
        {
            ugradeBt1.SetActive(false);
        }

        cost_b = GameObject.Find("1stFoodCourt").GetComponent<Departments>().cost;
 
        if (cost_b <= money.money)
        {
            ugradeBt2.SetActive(true);
        }
        else
        {
            ugradeBt2.SetActive(false);
        }
        cost_c = GameObject.Find("2ndRestroom").GetComponent<Departments>().cost;
        if (cost_c <= money.money)
        {
            ugradeBt3.SetActive(true);
        }
        else
        {
            ugradeBt3.SetActive(false);
        }
        cost_d = GameObject.Find("2ndCosmeticsStore").GetComponent<Departments>().cost;

        if (cost_d <= money.money)
        {
            ugradeBt4.SetActive(true);
        }
        else
        {
            ugradeBt4.SetActive(false);
        }
    }
}
