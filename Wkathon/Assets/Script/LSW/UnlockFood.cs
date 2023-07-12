using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class UnlockFood : MonoBehaviour
{
    public Dictionary<string, Tuple<Int32, bool>> foodDict; // {���� �̸�, (��� ����, ��� ����)}
    PlayerProps props;
    Money money;

    private void Start()
    {
        foodDict = new Dictionary<string, Tuple<Int32, bool>>
        {
            { "fish-shaped bun", Tuple.Create(100,  false) },
            { "hotdog",          Tuple.Create(300,  false) },
            { "bibimbap",        Tuple.Create(500,  false) },
            { "steak",           Tuple.Create(700,  false) },
            { "lobster",         Tuple.Create(1000, false) }
        };
        props = FindObjectOfType<PlayerProps>();
    }

    public void Unlock(string foodName)
    {
        Int32 foodCost = foodDict[foodName].Item1;
        
        if (foodDict[foodName].Item2)
        {
            print("�̹� ����� ����");
        } else if (foodCost <= money.money)
        {
            money.money -= foodCost;
            foodDict.Remove(foodName);
            foodDict.Add(foodName, Tuple.Create(foodCost, true));
            print(foodName + " ��� ����");
        } else
        { 
            print(foodName + " ��� ����");
        }
    }
}
