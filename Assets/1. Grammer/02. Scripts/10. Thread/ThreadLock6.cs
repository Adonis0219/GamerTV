using System.Threading;
using UnityEngine;

public class ThreadLock6 : MonoBehaviour
{
    private static readonly object _lock = new object();
    bool isPingTurn = true;

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
            while (!isPingTurn)
            {
                Monitor.Wait(_lock);   // 대기 및 lock 해제
            }
            Debug.Log("Ping");
            isPingTurn = false;     // 다음은 pong의 차례
            Monitor.Pulse(_lock);  // 대기 중인 pong 스레드에게 신호를 보냄
        }
    }
    void Pong()
    {
        lock (_lock)
        {
            while (isPingTurn)
            {
                Monitor.Wait(_lock);   // 대기 및 lock 해제
            }
            isPingTurn = true;      // 다음은 ping의 차례
            Debug.Log("Ping");
            Monitor.Pulse(_lock);  // 대기 중인 ping 스레드에게 신호를 보냄
        }
    }
}
