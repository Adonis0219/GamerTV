using System;
using UnityEngine;
using UnityEngine.UI;

public class Func2 : MonoBehaviour
{
    Button button;

    void Start()
    {
        Func<int> func1 = () => 1;

        Func<int, int> func2 = num => num + 1;

        int result1 = func1.Invoke();
        int result2 = func2.Invoke(1);

        Debug.Log($"Result1: {result1}, Result2: {result2}");   
    }

    //int Test() { return 1; }
    //int Test(int a) { return 1; }
}
