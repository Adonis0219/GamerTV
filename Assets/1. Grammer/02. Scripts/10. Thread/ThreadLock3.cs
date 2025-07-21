using System.Threading;
using UnityEngine;

public class ThreadLock3 : MonoBehaviour
{
    Thread t1, t2;

    int num;
    void Start()
    {
        num= 0;
        t1 = new Thread(TestFunction);
        t2 = new Thread(TestFunction);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
        Debug.Log($"num: {num}");   // 20000
    }

    // Interlocked 원자적 연산 (Atomic Operation)
    // 하나의 스레드가 연산 상태에 들어 갔을 때,
    // 다른 스레드가 연산 상태에 들어오지 못하게 하는 방법
    void TestFunction()
    {
        for (int i = 0; i < 10000; i++)
        {
            Interlocked.Increment(ref num);
        }
    }
}
