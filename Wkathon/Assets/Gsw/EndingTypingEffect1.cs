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
    private string m_text = "당신은 유지보수를 무사히 마쳐 서진타운 재건축을 완료하였다";
    private string m_text2 = "당신 덕에 써버는 무사히 공연을 마쳤고";
    private string m_text3 = "공연을 보러 온 사람들 또한 아무 일 없이 공연을 볼 수 있었다";
    private string m_text4 = "감사합니다";


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
