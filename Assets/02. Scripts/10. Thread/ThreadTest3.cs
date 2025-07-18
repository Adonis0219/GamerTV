using System.Threading;
using UnityEngine;

public class ThreadTest3 : MonoBehaviour
{
    Thread thread;

    void Start()
    {
        // ParameterizedThreadStart -> object Ÿ���� �Ű������� �޴� delegate
        thread = new Thread(new ParameterizedThreadStart(Temp));
        thread = new Thread(Temp); // C# 2.0 ��� (�� ������ ���)
        thread.Start(4); // �Ű������� �ְ� ������ ����  
    }

    void Temp(object num)
    {
        Debug.Log("������ ����");
        Debug.Log(thread.ThreadState);
        Thread.Sleep(2000); // 2�� ��� -> ������ ����
        Debug.Log(num); // �Ű����� ���
        Debug.Log("������ ����");
    }
}