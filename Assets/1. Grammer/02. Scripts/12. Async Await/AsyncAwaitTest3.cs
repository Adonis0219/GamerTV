using System;
using System.IO;
using System.Threading;
using UnityEngine;

public class AsyncAwaitTest3 : MonoBehaviour
{
    // C# 1.0���� �񵿱� ���� ���
    // BeginInvoke�� EndInvoke�� ����� �񵿱� ����

    private void Start()
    {
        Action action = LongRunningOperaion;
        IAsyncResult result = action.BeginInvoke(new AsyncCallback(EndOperationCallback), null);    
    }

    private void LongRunningOperaion()
    {
        // ���� �ɸ��� �۾� (3�� ����)
        Thread.Sleep(3000);
        Debug.Log("���� �ɸ��� �۾� �Ϸ�");
    }

    private void EndOperationCallback(IAsyncResult ar)
    {
        Debug.Log("�ݹ� ����");
    }
}
