using System;
using System.Threading;
using UnityEngine;

public class ThreadTest5 : MonoBehaviour
{
    // ����
    Thread thread1, thread2;

    private void Start()
    {
        thread1 = new Thread(Thread1Function);
        thread1.Start(); // thread1 ����
    }

    void Thread1Function()
    {
        Debug.Log("thread1 ����");
        thread2 = new Thread(Thread2Function);
        thread2.Start();
        thread2.Join(); // thread2�� ���� ������ ��ٸ�
        Debug.Log("Join �Ϸ�");
    }

    private void Thread2Function()
    {
        Debug.Log("thread2 ����");
        Thread.Sleep(2000); // 2�� ���
        Debug.Log("thread2 ����");
    }
}