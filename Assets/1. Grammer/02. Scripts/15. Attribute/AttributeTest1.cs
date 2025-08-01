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
    [MyCustom("�׽�Ʈ�� �޼��� �Դϴ�.")]
    public void TestMethod()
    {
        Debug.Log("�׽�Ʈ �޼��� ����");
    }
}

public class AttributeTest1 : MonoBehaviour
{
    private void Start()
    {
        Type myTestClass = typeof(MyTestClass);

        // MyTestClass ������ myTestClass �ȿ� �ִ� ��� �޼��带 ������
        foreach (var one in myTestClass.GetMethods())
        {
            // GetCustomAttribute() : ��� Attribute�� �������� �޼���
            // Attribute �������� ��ȯ���ֱ⿡ ����� ����ȯ�ؾ� �Ѵ�
            var attribute = (MyCustomAttribute)one.GetCustomAttribute(typeof(MyCustomAttribute));

            if (attribute != null)
            {
                Debug.Log(attribute.Desc);
                // �ν��Ͻ��� ������ �ش� �޼ҵ嵵 ������� ����
                one.Invoke(Activator.CreateInstance(typeof(MyTestClass)), null);
            }
        }
    }
}
