using System;
using UnityEngine;

public class Func1 : MonoBehaviour
{
    Func<int> func;

    void Start()
    {
        func = () =>
        {
            int num2 = 3;
            Debug.Log(num2);
            return num2;
        };

        func += () =>
        {
            Debug.Log(int.MinValue);
            return int.MinValue;
        };

        int num1 = func.Invoke();
    }
}
