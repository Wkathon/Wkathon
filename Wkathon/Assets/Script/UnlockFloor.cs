using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class UnlockFloor : MonoBehaviour
{
    public Int32 cost = 5000; // 층 잠금 해제 시 드는 비용
    public Int32 floor;
    public Money money;
    public Image panel; // 층을 표시하는 패널
    public GameObject lockObjects; // 열릴 때 삭제되는 오브젝트들

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
            print("언락 성공");
        } else
        {
            print("언락 실패");
            // 언락 실패
        }
    }
}
