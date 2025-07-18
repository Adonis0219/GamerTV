using System;
using System.Threading;
using UnityEngine;

public class ThreadTest6 : MonoBehaviour
{
    // Abort �޼��带 ����Ͽ� �����带 ���� �����ϴ� ����
    Thread thread1;

    private void Start()
    {
        thread1 = new Thread(ThreadFunction);
        thread1.Start();
    }

    private void ThreadFunction()
    {
        try // ���ܰ� �߻��� �� �ִ� ����
        {
            Debug.Log("������ ����");
            Thread.Sleep(5000); // 5�� ���
            Debug.Log("������ ����");
        }
        catch (ThreadAbortException) // ���� �߻� �� ������ ���� 1
        {
            Debug.Log("������ ���� ����");
        }
        catch (ThreadInterruptedException) // ���� �߻� �� ������ ���� 2
        {
            Debug.Log("������ WaitSleepJoin");
        }
    }

    private void Update()
    {
        // ���� �ð��� ���� �� �����带 ���� ����
        if (Time.timeSinceLevelLoad > 2f)   // ���÷� 2�� ���
        {
            thread1.Abort(); // ���ڸ��� ���� ����
            thread1.Interrupt(); // WaitSleepJoin ���°� �� �� ����
        }
    }
}