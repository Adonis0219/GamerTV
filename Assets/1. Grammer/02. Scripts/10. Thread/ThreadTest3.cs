using System.Threading;
using UnityEngine;

public class ThreadTest3 : MonoBehaviour
{
    Thread thread;

    void Start()
    {
        // ParameterizedThreadStart -> object 타입의 매개변수를 받는 delegate
        thread = new Thread(new ParameterizedThreadStart(Temp));
        thread = new Thread(Temp); // C# 2.0 방식 (더 간단한 방법)
        thread.Start(4); // 매개변수를 넣고 스레드 시작  
    }

    void Temp(object num)
    {
        Debug.Log("스레드 시작");
        Debug.Log(thread.ThreadState);
        Thread.Sleep(2000); // 2초 대기 -> 스레드 중지
        Debug.Log(num); // 매개변수 출력
        Debug.Log("스레드 종료");
    }
}