using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Departments : MonoBehaviour
{
    // ��ȭ�� ����
    //public Int32 payBonus = 0;
    public Int32 level = 0;
    public Int32 cost = 500; // ���� ���׷��̵� ���
    public string deptName = "restroom";
    Money money;

    private void Start()
    {
        money = FindObjectOfType<Money>();
    }

    public void Upgrade()
    {
        if (cost <= money.money)
        {
            money.money -= cost;
            cost += 100;
            level += 1;
            //payBonus += 50;
            money.pay += 50;
            print(string.Format("{0} ���׷��̵� ����, ���� {1}�Դϴ�.", deptName, level));
        } else
        {
            print(deptName + " ���׷��̵� ����");
        }
    }
}
