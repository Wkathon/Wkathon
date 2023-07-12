using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public enum BtnType{
    Start,
    Quit
}
public class BtnManager : MonoBehaviour
{
    public BtnType type;

    public void Update()
    {
        if(SceneManager.GetActiveScene().name == "StartScene" && Input.GetMouseButtonDown(0))
        {
            Loading.LoadScene("Ingame");
        }
    }

    public void OnBtnClick()
    {
        switch (type)
        {
            case BtnType.Quit:
                Application.Quit();
                break;
        }
    }
}
