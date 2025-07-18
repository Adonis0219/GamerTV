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

            // ���� ��� ��ȯ
            public object Current { get { return arr[index]; } }

            public bool MoveNext()  // ���� ��ҷ� �̵� / ���� ��Ұ� ������ true, ������ false ��ȯ
            {
                if (index == arr.Length - 1)
                    return false; // �� �̻� ��Ұ� ������ false ��ȯ

                index++; // ���� ��ҷ� �̵�
                return index < arr.Length; // ���� �ε����� �迭 ���̺��� ������ true ��ȯ
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
