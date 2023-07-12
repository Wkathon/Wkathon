using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public GameObject buildingA;
    public GameObject buildingB;
    public GameObject buildingC;
    public GameObject buildingD;

    private int buildingA_Lv;
    private int buildingB_Lv;
    private int buildingC_Lv;
    private int buildingD_Lv;
    // Start is called before the first frame update
    void Start()
    {
        buildingA = GameObject.Find("1stConcertHall");
        buildingB = GameObject.Find("1stFoodCourt");
        buildingC = GameObject.Find("2ndRestroom");
        buildingD = GameObject.Find("2ndCosmeticsStore");

        ugradeBt1 = buildingA.transform.Find("Confirm Upgrade Btn").gameObject;
        ugradeBt2 = buildingB.transform.Find("Confirm Upgrade Btn").gameObject;
        ugradeBt3 = buildingC.transform.Find("Confirm Upgrade Btn").gameObject;
        ugradeBt4 = buildingD.transform.Find("Confirm Upgrade Btn").gameObject;

    }

    // Update is called once per frame
    void Update()
    {

        buildingA_Lv = buildingA.GetComponent<Departments>().level;
        Debug.Log(buildingA_Lv);
        buildingB_Lv = buildingB.GetComponent<Departments>().level;
        buildingC_Lv = buildingC.GetComponent<Departments>().level;
        buildingD_Lv = buildingD.GetComponent<Departments>().level;

        money = FindObjectOfType<Money>();
        cost_a = buildingA.activeSelf ? buildingA.GetComponent<Departments>().cost : 2147483647;

        if (cost_a <= money.money)
        {
            ugradeBt1.SetActive(true);
        } else
        {
            ugradeBt1.SetActive(false);
        }

        cost_b = buildingB.activeSelf ? buildingB.GetComponent<Departments>().cost : 2147483647;

        if (cost_b <= money.money)
        {
            ugradeBt2.SetActive(true);
        }
        else
        {
            ugradeBt2.SetActive(false);
        }
        cost_c = buildingC.activeSelf ? buildingC.GetComponent<Departments>().cost : 2147483647;
        if (cost_c <= money.money)
        {
            ugradeBt3.SetActive(true);
        }
        else
        {
            ugradeBt3.SetActive(false);
        }
        cost_d = buildingD.activeSelf ? buildingD.GetComponent<Departments>().cost : 2147483647;

        if (cost_d <= money.money)
        {
            ugradeBt4.SetActive(true);
        }
        else
        {
            ugradeBt4.SetActive(false);
        }
        if (buildingA_Lv >= 20 && buildingB_Lv >= 20 && buildingC_Lv >= 20 && buildingD_Lv >= 20)
        {
            SceneManager.LoadScene("Ending");
        }
    }
}
