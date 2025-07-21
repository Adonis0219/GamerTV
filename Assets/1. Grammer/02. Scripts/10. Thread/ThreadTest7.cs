using System.Threading;
using UnityEngine;

public class ThreadTest7 : MonoBehaviour
{
    // 스레드 실행 순서
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread thread = new Thread(TestTread);
            thread.Start(i);
        }
    }

    // 1, 2, 3, ... 순서대로 실행
    void TestTread(object num)
    {
        Debug.Log($"{num}번째 스레드");
    }
}
