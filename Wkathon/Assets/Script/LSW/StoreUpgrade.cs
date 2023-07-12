using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreUpgrade : MonoBehaviour
{
    [SerializeField]
    private Int32 cost = 50; // �ǹ� ���׷��̵� ���
    public PlayerProps props;

    private void Start()
    {
        props = FindObjectOfType<PlayerProps>(); // PlayerProps ã��
    }

    public void Upgrade()
    {
        if (props.money >= cost)
        {
            props.storeLvl += 1;
            props.money -= cost;
            cost += 50;
            print("���׷��̵� ����, ���� ���� " + props.storeLvl + "�Դϴ�.");
        } else
        {
            print("���׷��̵� ����");
            // ���׷��̵� ����
        }
    }
}
