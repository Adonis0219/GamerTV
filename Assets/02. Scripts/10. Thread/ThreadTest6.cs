using System;
using System.Threading;
using UnityEngine;

public class ThreadTest6 : MonoBehaviour
{
    // Abort 메서드를 사용하여 스레드를 강제 종료하는 예제
    Thread thread1;

    private void Start()
    {
        thread1 = new Thread(ThreadFunction);
        thread1.Start();
    }

    private void ThreadFunction()
    {
        try // 예외가 발생할 수 있는 구문
        {
            Debug.Log("스레드 시작");
            Thread.Sleep(5000); // 5초 대기
            Debug.Log("스레드 종료");
        }
        catch (ThreadAbortException) // 예외 발생 시 실행할 구문 1
        {
            Debug.Log("스레드 강제 종료");
        }
        catch (ThreadInterruptedException) // 예외 발생 시 실행할 구문 2
        {
            Debug.Log("스레드 WaitSleepJoin");
        }
    }

    private void Update()
    {
        // 일정 시간이 지난 후 스레드를 강제 종료
        if (Time.timeSinceLevelLoad > 2f)   // 예시로 2초 대기
        {
            thread1.Abort(); // 하자마자 강제 종료
            thread1.Interrupt(); // WaitSleepJoin 상태가 될 때 종료
        }
    }
}