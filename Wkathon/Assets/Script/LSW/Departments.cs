using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Departments : MonoBehaviour
{
    // 백화점 매장
    //public Int32 payBonus = 0;
    public Int32 level = 0;
    public Int32 cost = 500; // 매장 업그레이드 비용
    public string deptName = "restroom";
    Money money;

    private void Start()
    {
        money = FindObjectOfType<Money>();
    }

    public void Upgrade()
    {
        // 매장이 아닌 초록색 업글 버튼을 눌러야 메서드가 실행됨
        if (cost <= money.money)
        {
            money.money -= cost;
            level += 1;
            //payBonus += 50;
            money.pay += 50;
            print(string.Format("{0} 업그레이드 성공, 레벨 {1}입니다.", deptName, level));
        } else
        {
            print(deptName + " 업그레이드 실패");
        }
    }
}
