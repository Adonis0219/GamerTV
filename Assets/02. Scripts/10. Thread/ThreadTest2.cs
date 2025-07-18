using System.Threading;
using UnityEngine;

public class ThreadTest2 : MonoBehaviour
{
    Thread thread;

    void Start()
    {
        // 스레드 생성 -> Temp 메서드를 실행하는 스레드 생성
        thread = new Thread(new ThreadStart(Temp)); // C# 1.0 방식
        thread = new Thread(Temp); // C# 2.0 방식 (더 간단한 방법)
        thread.Start(); // 스레드 시작   
    }

    void Temp()
    {
        Debug.Log("스레드 시작");
        Debug.Log(thread.ThreadState);
        Thread.Sleep(2000); // 2초 대기 -> 스레드 중지
        Debug.Log("스레드 종료");
    }
}
