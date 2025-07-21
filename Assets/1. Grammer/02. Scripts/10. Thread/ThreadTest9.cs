using System.Threading;
using UnityEngine;

public class ThreadTest9 : MonoBehaviour
{
    void Start()
    {
        // 새로운 스레드 생성이 없다

        ThreadPool.QueueUserWorkItem(TestThreadPool, 1);

        // Thread.Start() 메소드가 없다
    }

    void TestThreadPool(object value)
    {
        Debug.Log($"{value}번째 스레드풀");
    }
}
