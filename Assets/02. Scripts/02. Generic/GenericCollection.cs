using System;
using System.Collections.Generic;
using UnityEngine;

public class GenericCollection : MonoBehaviour
{
    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    if (i == 1 && k == 2)
                        goto EXIT_FOR;  // goto���� ������� ������ break���� ������ ����ؾ� ��
                }
            }
        }
        
        EXIT_FOR:
        Debug.Log("EXIT");
    }

    public void List()
    {
        // ArrayList�� Generic��
        
        // List<T>
        List<int> list = new List<int>();

        // ����Ʈ�� �Ű������� ���� ���� �߰��ϴ� �Լ�
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);
        // 10, 20, 30, 40, 50
        
        // �Ű������� ���� �ε��� ��°�� ���Ҹ� �������ִ� �Լ�
        list.RemoveAt(0);
        // 20, 30, 40, 50
        
        // �Ű������� �ش��ϴ� ���Ҹ� �������ִ� �Լ�
        list.Remove(40);
        // 20, 30, 50
        
        // ù��° �Ű������� �ε��� �ι�° �Ű������� ���Ұ����� �߰����ִ� �Լ�
        list.Insert(1, 25);
        // 20, 25, 30, 50
    }

    public void Dictionary()
    {
        // HashTable<object, object>
        
        // Dictionary<TKey, TValue>
        Dictionary<string, string> dic = new Dictionary<string, string>();

        dic["�ϳ�"] = "one";
        dic["��"] = "two";
        dic["��"] = "three";
        dic["��"] = "four";

        Debug.Log(dic["�ϳ�"]);
        Debug.Log(dic["��"]);
        Debug.Log(dic["��"]);
        Debug.Log(dic["��"]);
    }
}
