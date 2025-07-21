using System.Threading;
using UnityEngine;

public class ThreadTest7 : MonoBehaviour
{
    // ������ ���� ����
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread thread = new Thread(TestTread);
            thread.Start(i);
        }
    }

    // 1, 2, 3, ... ������� ����
    void TestTread(object num)
    {
        Debug.Log($"{num}��° ������");
    }
}
