using System.Threading;
using UnityEngine;

public class ThreadTest8 : MonoBehaviour
{
    // 스레드 풀


    // 스레드 동작 방식
    // 1) 상시 실행 : 스레드가 생성되면 비교적 오랜 시간동안 생성돼 있는 방식, 무한 루프가 많음
    // 2) 일회성 임시 실행 : 특정 연산을 수행하고 종료되는 방식, 짧은 시간동안 실행됨

    // 스레드 풀 사용 이유
    // 스레드 풀은 스레드를 미리 생성해 놓고, 필요할 때마다 재사용하는 방식으로,
    // 스레드 생성과 종료에 드는 비용을 줄여 성능을 향상시킵니다.
    void Start()
    {
        // 새로운 스레드 생성이 없다

        ThreadPool.QueueUserWorkItem(TestThreadPool);

        // Thread.Start() 메소드가 없다

        Thread thread = new Thread(Test);
    }

    void TestThreadPool(object value)
    {
        Debug.Log("스레드풀 시작");
    }

    void Test()
    {
        while (true)
        {

        }
    }
}
