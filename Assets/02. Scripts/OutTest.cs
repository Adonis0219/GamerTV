using System;
using Unity.VisualScripting;
using UnityEngine;

public class OutTest : MonoBehaviour
{
    bool AddForPositive(int a, int b, out int result)
    {
        // Debug.Log(result); // result는 출력용이므로 초기화되지 않아서 오류

        result = a + b; // result 출력값 저장

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
