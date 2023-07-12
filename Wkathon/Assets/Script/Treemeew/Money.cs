using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Money : MonoBehaviour
{
    public float payday;
    public int money;
    public TextMeshProUGUI showMoney;
    public int pay = 100;

    void Update()
    {
        payday += Time.deltaTime;

        if (payday >= 2)
        {
            money += pay;
            payday = 0;
        }

        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            money += pay / 55;
        }

        showMoney.text = money.ToString();
    }
}
