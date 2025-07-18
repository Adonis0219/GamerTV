using UnityEngine;

public class Enumerator7 : MonoBehaviour
{
    public class MyList
    {
        public enumerator GetEnumerator()
        {
            enumerator enumerator = new enumerator();
            return enumerator;
        }

        public class enumerator
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
        }
    }
    void Start()
    {
        MyList myList = new MyList();

        foreach (var one in myList)
            Debug.Log(one); // 1, 2, 3, 4, 5
    }
}
