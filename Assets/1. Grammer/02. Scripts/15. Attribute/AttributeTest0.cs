using System;
using UnityEngine;

public class AttributeTest0 : MonoBehaviour
{
    void Start()
    {
        TestMethod();
    }
    
    [Obsolete("TestMethod�� �� �̻� ������� �ʽ��ϴ�.")]
    public void TestMethod()
    {
        Debug.Log("TestMethod");
    }
}
