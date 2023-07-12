using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeUser : MonoBehaviour
{
    [SerializeField]
    private Int32 cost = 50; // �ǹ� ���׷��̵� ���
    public PlayerProps props;
    public Money money;

    private void Start()
    {
        props = FindObjectOfType<PlayerProps>(); // PlayerProps ã��
        money = FindObjectOfType<Money>();
    }

    public void UpgradeMethod()
    {
        if (money.money >= cost)
        {
            props.storeLvl += 1;
            money.money -= cost;
            money.pay += 20;
            cost += 50;
            print("���׷��̵� ����, ���� ���� " + props.storeLvl + "�Դϴ�.");
        } else
        {
            print("���׷��̵� ����");
            // ���׷��̵� ����
        }
    }
}
