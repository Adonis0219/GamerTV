using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Enumerator1 : MonoBehaviour
{
    // Enumerator(������)
    
    // ������ ��Ҹ� �ϳ��� �����ϴ� ���
    // C#������ IEnumerator �������̽��� �̿��ؼ� ������ �� ����
    void Start()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

        foreach (var one in list)
            Debug.Log(one); // 1, 2, 3, 4, 5
    }
}
