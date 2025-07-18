using System;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    private static List<GameObject> objs = new List<GameObject>();  // ���� �ʵ�

    public int num;

    public static void FindObj(string _name)    // ���� �޼ҵ�
    {
        GameObject go = GameObject.Find(_name);
        objs.Add(go);   // ���� �޼ҵ忡�� ���� �ʵ忡 ����
    }

    public static GameObject ReturnObj(string _name)    // ���� �޼ҵ�
    {
        for (int i = 0; i < objs.Count; i++)
        {
            if (objs[i].name == _name) return objs[i];  // ���� �޼ҵ忡�� ���� �ʵ忡 ����
        }
        return null;
    }

    public static void RemoveObj(string _name)  // ���� �޼ҵ�
    {
        for (int i = 0; i < objs.Count; i++)    // ���� �޼ҵ忡�� ���� �ʵ忡 ����
        {
            if (objs[i].name == _name) objs.Remove(objs[i]);
        }
    }
}

public class staticMethod : MonoBehaviour
{
    void Start()
    {
        Util.FindObj("Test1");
        Util.FindObj("Test2");
        Util.FindObj("Test3");
        
        Util.RemoveObj("Test2");

        Util.ReturnObj("Test1");
    }
}

public class Test : MonoBehaviour
{
    public class Test1
    {
        // �������� ���� �ʵ��
        // �ν��Ͻ��� ����� ������ ���� �Ұ���
        // �ش� Ŭ������ �ν��Ͻ��� �Ҽ�
        public static int num;

        // �ش� Ŭ������ �Ҽ�
        public static void Test123()
        {
            num++;
        }
    }

    private void Start()
    {
        Test1 t = new Test1();

        //t.num = 0;
    }
}
