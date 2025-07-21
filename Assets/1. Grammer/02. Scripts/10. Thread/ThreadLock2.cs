using System.Threading;
using UnityEngine;

public class ThreadLock2 : MonoBehaviour
{
    Thread t1, t2;

    int num;

    private readonly object lockObjj = new object(); // 동일한 잠금 객체

    void Start()
    {
        num= 0;
        t1 = new Thread(TestFunction);
        t2 = new Thread(TestFunction);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
        Debug.Log($"num: {num}");   // 20000 -> 실제 10000
    }

    void TestFunction()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (lockObjj) // 동일한 잠금 객체를 사용하여 동기화
            {
                num++;
            }
        }
    }
}
