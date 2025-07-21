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
            Monitor.Wait(_lock);   // ��� �� lock ����
            Debug.Log("Ping");
            Monitor.Pulse(_lock);  // ��� ���� pong �����忡�� ��ȣ�� ����
        }
    }
    void Pong()
    {
        lock (_lock)
        {
            Monitor.Wait(_lock);   // ��� �� lock ����
            Debug.Log("Ping");
            Monitor.Pulse(_lock);  // ��� ���� ping �����忡�� ��ȣ�� ����
        }
    }
}
