using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncAwaitTest4_1 : MonoBehaviour
{
    async void Start()
    {
        Debug.Log("메인 스레드 시작");

        await SumAsync(10, 20); // 비동기 메서드 호출
        await SumAsyncR(20, 30);

        Debug.Log("메인 스레드 진행 중");
    }

    async Task SumAsync(int a, int b)
    {
        // Task.Delay를 사용하여 오래 걸리는 작업을 비동기적으로 수행
        await Task.Delay(3000); // 3초 지연
        int num3 = a + b;
        Debug.Log("오래 걸리는 작업 완료");
        Debug.Log($"비동기 작업 결과: {num3}");
    }

    async Task<int> SumAsyncR(int a, int b)
    {
        await Task.Delay(3000);
        Debug.Log("오래 걸리는 작업 완료");
        return a + b;
    }
}

public class AsyncAwaitTest4_2 : MonoBehaviour
{
    EventHandler eventHandler;

    private void Start()
    {
        Debug.Log("메인 스레드 시작");

        eventHandler += VoidAsync;
        eventHandler.Invoke(this, EventArgs.Empty);
    }

    async void VoidAsync(object sender, EventArgs e)
    {
        int result = await SumAsync(10, 20);
        Debug.Log($"비동기 작업 결과 : {result}");
    }

    private async Task<int> SumAsync(int v1, int v2)
    {
        await Task.Delay(3000); // 3초 대기
        Debug.Log("오래 걸리는 작업 완료");
        return v1 + v2;
    }
}
