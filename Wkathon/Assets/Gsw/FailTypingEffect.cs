using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class FailTypingEffect : MonoBehaviour
{
    [SerializeField]
    private Text text;
    private string m_text = "유지보수를 제대로 하지 못해 결국 건물이 무너졌다";
    private string m_text2 = "많은 사람들이 다쳤고 죽었다";
    private string m_text3 = "당신이 유지보수를 열심히 하여 서진타운을 재건축하였다면 사람들을 살릴 수 있었지 않았을까";


    private void Start()
    {
        StartCoroutine(Typing());
    }
    IEnumerator Typing()
    {
        yield return new WaitForSeconds(2f);
        for(int i = 0; i <= m_text.Length; i++)
        {
            text.text = m_text.Substring(0,i);
            yield return new WaitForSeconds(0.15f);
        }
        yield return new WaitForSeconds(1f);
        text.text = m_text2;
        for (int i = 0; i <= m_text2.Length; i++)
        {
            text.text = m_text2.Substring(0, i);
            yield return new WaitForSeconds(0.15f);
        }
        yield return new WaitForSeconds(1f);
        text.text = m_text3;
        for (int i = 0; i <= m_text3.Length; i++)
        {
            text.text = m_text3.Substring(0, i);
            yield return new WaitForSeconds(0.15f);
        }
        yield return new WaitForSeconds(1f);
    }
}
