using System.Threading;
using UnityEngine;

public class ThreadTest9 : MonoBehaviour
{
    void Start()
    {
        // ���ο� ������ ������ ����

        ThreadPool.QueueUserWorkItem(TestThreadPool, 1);

        // Thread.Start() �޼ҵ尡 ����
    }

    void TestThreadPool(object value)
    {
        Debug.Log($"{value}��° ������Ǯ");
    }
}
