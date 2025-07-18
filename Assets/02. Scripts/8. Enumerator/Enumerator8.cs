using System.Collections;
using UnityEngine;

public class Enumerator8 : MonoBehaviour
{
    public class MyList : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            IEnumerator enumerator = new enumerator();
            return enumerator;
        }

        public class enumerator : IEnumerator
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int index = -1;

            // 현재 요소 반환
            public object Current { get { return arr[index]; } }

            public bool MoveNext()  // 다음 요소로 이동 / 현재 요소가 있으면 true, 없으면 false 반환
            {
                if (index == arr.Length - 1)
                    return false; // 더 이상 요소가 없으면 false 반환

                index++; // 다음 요소로 이동
                return index < arr.Length; // 현재 인덱스가 배열 길이보다 작으면 true 반환
            }

            public void Reset()
            {
                index = -1; // 인덱스를 초기화하여 첫 번째 요소로 돌아감
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
