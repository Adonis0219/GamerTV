using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Coroutine3 : MonoBehaviour
{
    public Image img;

    float alpha = 0f;
    float fadeTime = 3.0f;

    private void Start()
    {
        StartCoroutine(FadeIn());   // 가급적 이 방식으로 사용
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
