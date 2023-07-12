using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeUser : MonoBehaviour
{
    [SerializeField]
    private Int32 cost = 50; // 건물 업그레이드 비용
    public PlayerProps props;
    public Money money;

    private void Start()
    {
        props = FindObjectOfType<PlayerProps>(); // PlayerProps 찾기
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
            print("업그레이드 성공, 이제 레벨 " + props.storeLvl + "입니다.");
        } else
        {
            print("업그레이드 실패");
            // 업그레이드 실패
        }
    }
}
