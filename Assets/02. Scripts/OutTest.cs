using System;
using Unity.VisualScripting;
using UnityEngine;

public class OutTest : MonoBehaviour
{
    bool AddForPositive(int a, int b, out int result)
    {
        // Debug.Log(result); // result�� ��¿��̹Ƿ� �ʱ�ȭ���� �ʾƼ� ����

        result = a + b; // result ��°� ����

        if (result > 0)
            return true;
        else
            return false;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;

        if (AddForPositive(1, 2, out sum))
        {
            Debug.Log($"Positive : {sum}");
        }
    }
}

class ReturnClass
{
    private int a;
    private float b;
    private bool t;
}
