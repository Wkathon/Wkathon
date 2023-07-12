using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class UnlockFloor : MonoBehaviour
{
    public Int32 cost = 5000;
    [NotNull]
    public Int32 floor;
    public Money money;
    public Image panel;
    public GameObject[] lockObjects;

    private void Start()
    {
        money = FindObjectOfType<Money>();
        panel = transform.Find("Panel").GetComponent<Image>();
    }
    public void Unlock()
    {
        if (cost <= money.money)
        {
            money.money -= cost;
            foreach (var go in lockObjects) { go.SetActive(false); }
            panel.color = new Color(255, 255, 255, 100);
        } else
        {
            print("언락 실패");
            // 언락 실패
        }
    }
}
