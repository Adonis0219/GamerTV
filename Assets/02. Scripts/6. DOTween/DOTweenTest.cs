using System;
using UnityEngine;

public class DOTweenTest : MonoBehaviour
{
    private Vector3 startPos;   // A
    private Vector3 endPos = new Vector3(0, 5, 0); // B
    private float curValue;     // T

    private void Start()
    {
        startPos = transform.position;
        curValue = 0;
    }

    private void Update()
    {
        if (curValue < 1.0f)
        {
            curValue += Time.deltaTime;
            transform.position = Vector3.Lerp(startPos, endPos, curValue);
        }
    }
}
