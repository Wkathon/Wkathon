using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class UnlockFloor : MonoBehaviour
{
    public Int32 cost = 5000;
    [DisallowNull]
    public Int32 floor;
    public Money money;
    public Image panel;
    public GameObject lockObjects;

    private void Start()
    {
        money = FindObjectOfType<Money>();
        panel = transform.Find("Panel").GetComponent<Image>();
        lockObjects = transform.Find("Lock Objects").gameObject;
    }
    public void Unlock()
    {
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
