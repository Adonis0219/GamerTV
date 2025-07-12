using System;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    private static List<GameObject> objs = new List<GameObject>();  // 정적 필드

    public int num;

    public static void FindObj(string _name)    // 정적 메소드
    {
        GameObject go = GameObject.Find(_name);
        objs.Add(go);   // 정적 메소드에서 정적 필드에 접근
    }

    public static GameObject ReturnObj(string _name)    // 정적 메소드
    {
        for (int i = 0; i < objs.Count; i++)
        {
            if (objs[i].name == _name) return objs[i];  // 정적 메소드에서 정적 필드에 접근
        }
        return null;
    }

    public static void RemoveObj(string _name)  // 정적 메소드
    {
        for (int i = 0; i < objs.Count; i++)    // 정적 메소드에서 정적 필드에 접근
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
        // 정적이지 않은 필드는
        // 인스턴스를 만들기 전에는 접근 불가능
        // 해당 클래스의 인스턴스에 소속
        public static int num;

        // 해당 클래스에 소속
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
