using System.Threading;
using UnityEngine;

public class ThreadTest10 : MonoBehaviour
{
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            ThreadPool.QueueUserWorkItem(TestThreadPool, i);
        }
    }

    void TestThreadPool(object value)
    {
        Debug.Log($"{value}번째 스레드풀");
    }
}
