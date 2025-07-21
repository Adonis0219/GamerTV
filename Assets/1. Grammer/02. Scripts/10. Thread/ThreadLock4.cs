using System.Threading;
using UnityEngine;

public class ThreadLock4 : MonoBehaviour
{
    Thread t1, t2;

    int num;

    private readonly object lockObject = new object();

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

    void TestFunction()
    {
        for (int i = 0; i < 10000; i++)
        {
            Monitor.Enter(lockObject);
            try
            {
                num++;
            }
            finally
            {
                Monitor.Exit(lockObject);
            }
        }
    }
}
