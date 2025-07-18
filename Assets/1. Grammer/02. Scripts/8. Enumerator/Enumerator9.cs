using System.Collections;
using UnityEngine;

public class Enumerator10 : MonoBehaviour
{
    public class MyList : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int[] num = new int[5] { 1, 2, 3, 4, 5 };
            int index = -1;

            while (index < num.Length - 1)
            {
                index++;
                if (index == 4) yield break;

                yield return num[index]; // 현재 요소 반환
            }
        }
    }
    void Start()
    {
        MyList myList = new MyList();

        IEnumerator enumerator = myList.GetEnumerator();

        foreach (var one in myList)
        {
            Debug.Log(one); // 1, 2, 3, 4, 5
        }

        //while (enumerator.MoveNext()) // 다음 요소로 이동
        //{
        //    Debug.Log(enumerator.Current); // 현재 요소 출력
        //}

        enumerator.MoveNext(); // 첫 번째 요소로 이동
        Debug.Log(enumerator.Current); // 1
        enumerator.MoveNext(); // 두 번째 요소로 이동
        Debug.Log(enumerator.Current); // 2
        enumerator.MoveNext(); // 세 번째 요소로 이동
        Debug.Log(enumerator.Current); // 3
        enumerator.MoveNext(); // 네 번째 요소로 이동
        Debug.Log(enumerator.Current); // 4
        enumerator.MoveNext(); // 다섯 번째 요소로 이동
        Debug.Log(enumerator.Current); // 5

        if (!enumerator.MoveNext()) // 다음 요소가 없으면 false 반환
        {
            Debug.Log("더 이상 요소가 없습니다.");
        }
    }
}
