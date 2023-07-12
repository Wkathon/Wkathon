using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreUpgrade : MonoBehaviour
{
    [SerializeField]
    private Int32 cost = 50; // 건물 업그레이드 비용
    public PlayerProps props;

    private void Start()
    {
        props = FindObjectOfType<PlayerProps>(); // PlayerProps 찾기
    }

    public void Upgrade()
    {
        if (props.money >= cost)
        {
            props.storeLvl += 1;
            props.money -= cost;
            cost += 50;
            print("업그레이드 성공, 이제 레벨 " + props.storeLvl + "입니다.");
        } else
        {
            print("업그레이드 실패");
            // 업그레이드 실패
        }
    }
}
