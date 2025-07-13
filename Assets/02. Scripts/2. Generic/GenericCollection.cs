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
                        goto EXIT_FOR;  // goto문을 사용하지 않으면 break문을 여러개 사용해야 함
                }
            }
        }
        
        EXIT_FOR:
        Debug.Log("EXIT");
    }

    public void List()
    {
        // ArrayList의 Generic형
        
        // List<T>
        List<int> list = new List<int>();

        // 리스트에 매개변수로 받은 값을 추가하는 함수
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);
        // 10, 20, 30, 40, 50
        
        // 매개변수로 받은 인덱스 번째의 원소를 제거해주는 함수
        list.RemoveAt(0);
        // 20, 30, 40, 50
        
        // 매개변수에 해당하는 원소를 제거해주는 함수
        list.Remove(40);
        // 20, 30, 50
        
        // 첫번째 매개변수를 인덱스 두번째 매개변수를 원소값으로 추가해주는 함수
        list.Insert(1, 25);
        // 20, 25, 30, 50
    }

    public void Dictionary()
    {
        // HashTable<object, object>
        
        // Dictionary<TKey, TValue>
        Dictionary<string, string> dic = new Dictionary<string, string>();

        dic["하나"] = "one";
        dic["둘"] = "two";
        dic["셋"] = "three";
        dic["넷"] = "four";

        Debug.Log(dic["하나"]);
        Debug.Log(dic["둘"]);
        Debug.Log(dic["셋"]);
        Debug.Log(dic["넷"]);
    }
}
