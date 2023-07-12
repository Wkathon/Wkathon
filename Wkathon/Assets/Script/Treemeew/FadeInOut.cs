using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�Ϸ�� ��ũ��Ʈ
public enum FadeState { FadeIn = 0, FadeOut, FadeInOut, FadeLoop }
public class FadeInOut : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]
    private float fadeTime;
    [SerializeField]
    private AnimationCurve fadeCurve;
    private SpriteRenderer Sprite;
    private FadeState fadeState;
    void Awake()
    {
        Sprite = GetComponent<SpriteRenderer>();

        OnFade(FadeState.FadeLoop);
    }


    // Update is called once per frame
    void Update()
    {
        /*Color color = image.color;

        if(color.a > 0)
        {
            color.a -= Time.deltaTime;
        }

        image.color = color;*/
    }
    public void OnFade(FadeState state)
    {
        fadeState = state;

        switch (fadeState)
        {
            case FadeState.FadeIn:
                StartCoroutine(Fade(1, 0));
                break;
            case FadeState.FadeOut:
                StartCoroutine(Fade(0, 1));
                break;
            case FadeState.FadeInOut:
            case FadeState.FadeLoop:
                StartCoroutine(Fade_In_Out());
                break;
        }
    }
    private IEnumerator Fade_In_Out()
    {
        while (true)
        {

            yield return StartCoroutine(Fade(1, 0));

            yield return StartCoroutine(Fade(0, 2));

            if (fadeState == FadeState.FadeInOut)
            {
                break;
            }
        }
    }

    private IEnumerator Fade(float start, float end)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while (percent < 1)
        {
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;

            Color color = Sprite.color;
            color.a = Mathf.Lerp(start, end, percent);
            Sprite.color = color;

            yield return null;
        }
    }
}
