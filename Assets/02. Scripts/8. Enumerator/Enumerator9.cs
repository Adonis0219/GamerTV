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

                yield return num[index]; // ���� ��� ��ȯ
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
