using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Coroutine5 : MonoBehaviour
{
    public Image img;

    float alpha = 0f;
    float fadeTime = 3.0f;

    private void Start()
    {
        Coroutine co = StartCoroutine(FadeIn());

        // 코루틴을 중지하는 방법
        StopCoroutine(co);  // 가급적 이 방식 사용

        StopCoroutine(FadeIn());

        StopCoroutine("FadeIn");
    }

    IEnumerator FadeIn()
    {
        while (alpha < 1f)
        {
            alpha += Time.deltaTime / fadeTime;
            img.color = new Color(1, 1, 1, alpha);
            yield return null; // Wait for the next frame
        }
    }
}
