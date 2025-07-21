using System.Threading;
using UnityEngine;

public class ThreadLock5 : MonoBehaviour
{
    private static readonly object _lock = new object();

    void Start()
    {
        Thread pingThread = new Thread(Ping);
        Thread pongThread = new Thread(Pong);

        pingThread.Start();
        pongThread.Start();
    }

    void Ping()
    {
        lock (_lock)
        {
            Monitor.Wait(_lock);   // 대기 및 lock 해제
            Debug.Log("Ping");
            Monitor.Pulse(_lock);  // 대기 중인 pong 스레드에게 신호를 보냄
        }
    }
    void Pong()
    {
        lock (_lock)
        {
            Monitor.Wait(_lock);   // 대기 및 lock 해제
            Debug.Log("Ping");
            Monitor.Pulse(_lock);  // 대기 중인 ping 스레드에게 신호를 보냄
        }
    }
}
