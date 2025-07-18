using System.Threading;
using UnityEngine;

public class ThreadTest2 : MonoBehaviour
{
    Thread thread;

    void Start()
    {
        // ������ ���� -> Temp �޼��带 �����ϴ� ������ ����
        thread = new Thread(new ThreadStart(Temp)); // C# 1.0 ���
        thread = new Thread(Temp); // C# 2.0 ��� (�� ������ ���)
        thread.Start(); // ������ ����   
    }

    void Temp()
    {
        Debug.Log("������ ����");
        Debug.Log(thread.ThreadState);
        Thread.Sleep(2000); // 2�� ��� -> ������ ����
        Debug.Log("������ ����");
    }
}
