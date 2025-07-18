using System;
using UnityEngine;

public class LerpTest : MonoBehaviour
{
    private Vector3 startPos;   // ���۰� a
    private Vector3 endPos = new Vector3(0, 5, 0);  // ���� b

    private float curTime = 0;  // a�� b ���̸� ���������ϴ� t
    
    private float moveTime = 5.0f;  // �����̴� �ð�
    
    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        curTime += Time.deltaTime;

        // curTime�� 1�� �Ѿ�� Lerp �Լ� ���ο� t���� 0�� 1���̷� �����ϴ�
        // Clamp01 �Լ��� ����־ 0���� �۾����� �ʰ� 1�� �Ѿ�� �ʴ´�
        transform.position = Vector3.Lerp(startPos, endPos, curTime / moveTime);
    }
}
