using System;
using UnityEngine;

public class Action2 : MonoBehaviour
{
    Action<int> action1;
    Action<int, int> action2;
    Action<string, string, string> action3;

    void Start()
    {
        action1 = Test1;
        action2 = Test2;   
        action3 = Test3;

        action1.Invoke(10);
        action2.Invoke(10, 5);
        action3.Invoke("감사", "합니다", "여러분");
    }

    void Test1(int num) { Debug.Log(num); }
    void Test2(int num1, int num2) { Debug.Log(num1 + num2); }
    void Test3(string str1, string str2, string str3) { Debug.Log(str1 + str2 + str3); }
}
