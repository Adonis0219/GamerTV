using System;
using UnityEngine;

public class AttributeTest0 : MonoBehaviour
{
    void Start()
    {
        TestMethod();
    }
    
    [Obsolete("TestMethod는 더 이상 사용하지 않습니다.")]
    public void TestMethod()
    {
        Debug.Log("TestMethod");
    }
}
