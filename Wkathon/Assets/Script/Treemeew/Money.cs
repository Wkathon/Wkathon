using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Money : MonoBehaviour
{
    public float Payday;
    public int money;
    public TextMeshProUGUI ShowMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Payday+=Time.deltaTime;

        if (Payday >= 2)
        {
            money += 100;
            Payday = 0;
        }
        if (Input.GetMouseButtonDown(0))
        {
            money += 1;

        }

        ShowMoney.text = money.ToString();
    }
}
