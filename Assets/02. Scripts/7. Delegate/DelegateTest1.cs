using System;
using UnityEngine;

public class DelegateTest1 : MonoBehaviour
{
    public delegate void MyDelegate(); // ��������Ʈ Ÿ���� ����

    public MyDelegate _myDel; // ������ ��������Ʈ�� ����(��ü) ����

    #region 2

    public delegate int MyDelegate2(int num);   // ��������Ʈ Ÿ���� ����

    public MyDelegate2 _MyDel2; // ������ ��������Ʈ�� ����(��ü) ����
    
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
        // _myDel = new MyDelegate(TestFunction);  // C# 1.0 ���� ����

        // _myDel�� TestFunction�� �����ϴ� ����
        _myDel = TestFunction;  // C# 2.0 ���� ����

        _myDel();
    }
}
