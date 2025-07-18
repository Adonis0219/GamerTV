using System.Threading;
using UnityEngine;

public class ThreadTest1 : MonoBehaviour
{
    void Start()
    {
        // thread에 현재 스레드를 할당 -> 메인 스레드
        Thread thread = Thread.CurrentThread;
        // 스레드의 상태를 출력
        Debug.Log(thread.ThreadState);
    }
}
