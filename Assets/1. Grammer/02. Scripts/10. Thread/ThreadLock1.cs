using System.Threading;
using UnityEngine;

public class ThreadLock1 : MonoBehaviour
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
        Debug.Log($"num: {num}");   // 20000 -> ½ÇÁ¦ 10000
    }

    void TestFunction()
    {
        for (int i = 0; i < 10000; i++)
        {
            num++;
        }
    }
}
