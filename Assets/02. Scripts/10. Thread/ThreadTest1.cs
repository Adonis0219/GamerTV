using System.Threading;
using UnityEngine;

public class ThreadTest1 : MonoBehaviour
{
    void Start()
    {
        // thread�� ���� �����带 �Ҵ� -> ���� ������
        Thread thread = Thread.CurrentThread;
        // �������� ���¸� ���
        Debug.Log(thread.ThreadState);
    }
}
