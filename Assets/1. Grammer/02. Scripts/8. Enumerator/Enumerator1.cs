using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Enumerator1 : MonoBehaviour
{
    // Enumerator(열거자)
    
    // 데이터 요소를 하나씩 리턴하는 기능
    // C#에서는 IEnumerator 인터페이스를 이용해서 구현할 수 있음
    void Start()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

        foreach (var one in list)
            Debug.Log(one); // 1, 2, 3, 4, 5
    }
}
