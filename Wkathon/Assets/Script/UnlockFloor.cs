using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class UnlockFloor : MonoBehaviour
{
    public Int32 cost = 5000; // �� ��� ���� �� ��� ���
    public Int32 floor;
    public Money money;
    public Image panel; // ���� ǥ���ϴ� �г�
    public GameObject lockObjects; // ���� �� �����Ǵ� ������Ʈ��

    private void Start()
    {
        money = FindObjectOfType<Money>();
        if (lockObjects == null)
            lockObjects = transform.Find("Lock Objects").gameObject;
        if (panel == null)
            panel = transform.Find("Panel").GetComponent<Image>();
    }
    public void Unlock()
    {
        print("AA");
        if (cost <= money.money)
        {
            money.money -= cost;
            lockObjects.SetActive(false);
            panel.color = new Color32(255, 255, 255, 100);
            print("��� ����");
        } else
        {
            print("��� ����");
            // ��� ����
        }
    }
}
