using System;
using System.Threading;
using UnityEngine;

public class ThreadTest5 : MonoBehaviour
{
    // 조인
    Thread thread1, thread2;

    private void Start()
    {
        thread1 = new Thread(Thread1Function);
        thread1.Start(); // thread1 시작
    }

    void Thread1Function()
    {
        Debug.Log("thread1 시작");
        thread2 = new Thread(Thread2Function);
        thread2.Start();
        thread2.Join(); // thread2가 끝날 때까지 기다림
        Debug.Log("Join 완료");
    }

    private void Thread2Function()
    {
        Debug.Log("thread2 시작");
        Thread.Sleep(2000); // 2초 대기
        Debug.Log("thread2 종료");
    }
}