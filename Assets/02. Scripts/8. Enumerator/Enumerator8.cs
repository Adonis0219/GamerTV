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

            // ���� ��� ��ȯ
            public object Current { get { return arr[index]; } }

            public bool MoveNext()  // ���� ��ҷ� �̵� / ���� ��Ұ� ������ true, ������ false ��ȯ
            {
                if (index == arr.Length - 1)
                    return false; // �� �̻� ��Ұ� ������ false ��ȯ

                index++; // ���� ��ҷ� �̵�
                return index < arr.Length; // ���� �ε����� �迭 ���̺��� ������ true ��ȯ
            }

            public void Reset()
            {
                index = -1; // �ε����� �ʱ�ȭ�Ͽ� ù ��° ��ҷ� ���ư�
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

        //while (enumerator.MoveNext()) // ���� ��ҷ� �̵�
        //{
        //    Debug.Log(enumerator.Current); // ���� ��� ���
        //}

        enumerator.MoveNext(); // ù ��° ��ҷ� �̵�
        Debug.Log(enumerator.Current); // 1
        enumerator.MoveNext(); // �� ��° ��ҷ� �̵�
        Debug.Log(enumerator.Current); // 2
        enumerator.MoveNext(); // �� ��° ��ҷ� �̵�
        Debug.Log(enumerator.Current); // 3
        enumerator.MoveNext(); // �� ��° ��ҷ� �̵�
        Debug.Log(enumerator.Current); // 4
        enumerator.MoveNext(); // �ټ� ��° ��ҷ� �̵�
        Debug.Log(enumerator.Current); // 5

        if (!enumerator.MoveNext()) // ���� ��Ұ� ������ false ��ȯ
        {
            Debug.Log("�� �̻� ��Ұ� �����ϴ�.");
        }
    }
}
