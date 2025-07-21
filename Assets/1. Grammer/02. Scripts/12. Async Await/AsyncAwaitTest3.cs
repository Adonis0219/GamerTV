using System;
using System.IO;
using System.Threading;
using UnityEngine;

public class AsyncAwaitTest3 : MonoBehaviour
{
    // C# 1.0에서 비동기 샐행 방법
    // BeginInvoke와 EndInvoke를 사용한 비동기 실행

    private void Start()
    {
        Action action = LongRunningOperaion;
        IAsyncResult result = action.BeginInvoke(new AsyncCallback(EndOperationCallback), null);    
    }

    private void LongRunningOperaion()
    {
        // 오래 걸리는 작업 (3초 지연)
        Thread.Sleep(3000);
        Debug.Log("오래 걸리는 작업 완료");
    }

    private void EndOperationCallback(IAsyncResult ar)
    {
        Debug.Log("콜백 실행");
    }
}
