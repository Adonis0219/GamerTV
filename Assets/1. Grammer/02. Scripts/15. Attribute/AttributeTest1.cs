using System;
using System.Reflection;
using UnityEngine;

public class MyCustomAttribute : Attribute
{
    public string Desc { get; }

    public MyCustomAttribute(string desc)
    {
        Desc = desc;
    }
}

public class MyTestClass
{
    [MyCustom("테스트용 메서드 입니다.")]
    public void TestMethod()
    {
        Debug.Log("테스트 메서드 실행");
    }
}

public class AttributeTest1 : MonoBehaviour
{
    private void Start()
    {
        Type myTestClass = typeof(MyTestClass);

        // MyTestClass 형식의 myTestClass 안에 있는 모든 메서드를 가져옴
        foreach (var one in myTestClass.GetMethods())
        {
            // GetCustomAttribute() : 모든 Attribute를 가져오는 메서드
            // Attribute 형식으로 반환해주기에 명시적 형변환해야 한다
            var attribute = (MyCustomAttribute)one.GetCustomAttribute(typeof(MyCustomAttribute));

            if (attribute != null)
            {
                Debug.Log(attribute.Desc);
                // 인스턴스를 생성해 해당 메소드도 실행시켜 보자
                one.Invoke(Activator.CreateInstance(typeof(MyTestClass)), null);
            }
        }
    }
}
