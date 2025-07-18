using System;
using UnityEngine;

public class DelegateTest1 : MonoBehaviour
{
    public delegate void MyDelegate(); // 델리게이트 타입의 정의

    public MyDelegate _myDel; // 선언한 델리게이트의 변수(객체) 선언

    #region 2

    public delegate int MyDelegate2(int num);   // 델리게이트 타입의 정의

    public MyDelegate2 _MyDel2; // 선언한 델리게이트의 변수(객체) 선언
    
    #endregion
    
    public void TestFunction()
    {
        Debug.Log("Test");
    }

    #region 2
    public int TestFunction2(int num)
    {
        return num;
    }
    #endregion
    
    public void Start()
    {
        // _myDel = new MyDelegate(TestFunction);  // C# 1.0 버전 사용법

        // _myDel이 TestFunction을 참조하는 형태
        _myDel = TestFunction;  // C# 2.0 버전 사용법

        _myDel();
    }
}
