using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class BreakTime : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private TextMeshProUGUI text;
    private UpgradeBtn upgBtn;

    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        upgBtn = FindObjectOfType<UpgradeBtn>();
    }

    private void Update()
    {
        int min = (int)gameManager.BreakedTime / 60;
        float sec = (int)gameManager.BreakedTime % 60;

        text.text = "ºØ±«½Ã°£" + "[" + min.ToString("00") + ":" + sec.ToString("00") + "]";
        if(min < 1 && sec < 1)
        {
            switch(Random.Range(0, 4))
            {
                case 0:
                    Departments deptA = upgBtn.buildingA.GetComponent<Departments>();
                    Downgrade(deptA);
                    break;
                case 1:
                    Departments deptB = upgBtn.buildingB.GetComponent<Departments>();
                    Downgrade(deptB);
                    break;
                case 2:
                    Departments deptC = upgBtn.buildingC.GetComponent<Departments>();
                    Downgrade(deptC);
                    break;
                case 3:
                    Departments deptD = upgBtn.buildingD.GetComponent<Departments>();
                    Downgrade(deptD);
                    break;
            }
        }

    }

    void Downgrade(Departments dept)
    {
        dept.Downgrade();
        if (dept.level <= 0)
        {
            SceneManager.LoadScene("Fail");
        }
    }
}
