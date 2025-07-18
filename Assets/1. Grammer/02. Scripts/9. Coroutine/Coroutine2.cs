using UnityEngine;
using UnityEngine.UI;

public class Coroutine2 : MonoBehaviour
{
    public Image img;

    float alpha = 0f;
    float fadeTime = 3.0f;

    void Update()
    {
        if (alpha < 1f)
        {
            alpha += Time.deltaTime / fadeTime;
            img.color = new Color(1, 1, 1, alpha);
        }
    }
}
