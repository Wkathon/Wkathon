using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class EndingTypingEffect : MonoBehaviour
{
    [SerializeField]
    private Text text;
    private string m_text = "����� ���������� ������ ���� ����Ÿ�� ������� �Ϸ��Ͽ���";
    private string m_text2 = "��� ���� ����� ������ ������ ���ư�";
    private string m_text3 = "������ ���� �� ����� ���� �ƹ� �� ���� ������ �� �� �־���";
    private string m_text4 = "�����մϴ�";


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
        yield return new WaitForSeconds(3f);
        text.text = m_text4;
        yield return new WaitForSeconds(2f);
    }
}
