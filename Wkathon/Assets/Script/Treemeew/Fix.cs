using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fix : MonoBehaviour
{
    public int FixPrice;

    public int HP = 100;
    public int Heal_HP = 45;
    public Slider Show_HP;
    public static int dmg=15;

    public float currentTime;

    Money Money;



    // Update is called once per frame
    void Update()
    {

        Show_HP.value = HP;
        currentTime +=Time.deltaTime;
        if (currentTime >=100)
        {
            HP -= dmg;
            currentTime = 0;
        }
        if (HP <= 0)
        {

        }
    }

    public void fix()
    {
        Money.money -= FixPrice;
        HP += Heal_HP;
    }
}
