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
                Monitor.Wait(_lock);   // ��� �� lock ����
            }
            Debug.Log("Ping");
            isPingTurn = false;     // ������ pong�� ����
            Monitor.Pulse(_lock);  // ��� ���� pong �����忡�� ��ȣ�� ����
        }
    }
    void Pong()
    {
        lock (_lock)
        {
            while (isPingTurn)
            {
                Monitor.Wait(_lock);   // ��� �� lock ����
            }
            isPingTurn = true;      // ������ ping�� ����
            Debug.Log("Ping");
            Monitor.Pulse(_lock);  // ��� ���� ping �����忡�� ��ȣ�� ����
        }
    }
}
