using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Departments : MonoBehaviour
{
    // ��ȭ�� ����
    //public Int32 payBonus = 0;
    public int level = 1;
    public Int32 cost; // ���� ���׷��̵� ���
    public string deptName;
    Money money;

    public GameObject buildingA;
    public GameObject buildingB;
    public GameObject buildingC;
    public GameObject buildingD;

    private void Start()
    {

        buildingA = GameObject.Find("1stConcertHall");
        buildingB = GameObject.Find("1stFoodCourt");
        buildingC = GameObject.Find("2ndRestroom");
        buildingD = GameObject.Find("2ndCosmeticsStore");

        money = FindObjectOfType<Money>();
    }

    public void Upgrade()
    {
        if (cost <= money.money && level < 20)
        {
            money.money -= cost;
            cost += 100;
            level += 1;
            //payBonus += 50;
            money.pay += 50;
            print(string.Format("{0} ���׷��̵� ����, ���� {1}�Դϴ�.", deptName, level));

            if(deptName == "restroom")
            {
                buildingA.GetComponent<Departments>().level++;
            } else if (deptName == "foodcourt")
            {
                buildingB.GetComponent<Departments>().level++;
            } else if (deptName == "two_restroom")
            {
                buildingC.GetComponent<Departments>().level++;
            } else
            {
                buildingD.GetComponent<Departments>().level++;
            }


        }
        else if (level >= 20)
        {
            level = 20;
            print(deptName + "�ִ� �����Դϴ�");
        }
        else
        {
            print(deptName + " ���׷��̵� ����");
        }
    }

    public void Downgrade()
    {
        cost -= 100;
        level -= 1;
        money.pay -= 50;
        print(string.Format("{0} �ǹ��� ������ ���������ϴ�. ���� ���� {1}�Դϴ�.", deptName, level));
    }
}
