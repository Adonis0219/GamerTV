using System;
using UnityEngine;

public class LerpTest : MonoBehaviour
{
    private Vector3 startPos;   // 시작값 a
    private Vector3 endPos = new Vector3(0, 5, 0);  // 끝값 b

    private float curTime = 0;  // a와 b 사이를 선형보간하는 t
    
    private float moveTime = 5.0f;  // 움직이는 시간
    
    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        curTime += Time.deltaTime;

        // curTime이 1이 넘어가도 Lerp 함수 내부에 t값을 0과 1사이로 고정하는
        // Clamp01 함수가 들어있어서 0보다 작아지지 않고 1을 넘어가지 않는다
        transform.position = Vector3.Lerp(startPos, endPos, curTime / moveTime);
    }
}
