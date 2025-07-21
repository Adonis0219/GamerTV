using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class AsyncAwaitTest4_1 : MonoBehaviour
{
    async void Start()
    {
        Debug.Log("���� ������ ����");

        await SumAsync(10, 20); // �񵿱� �޼��� ȣ��
        await SumAsyncR(20, 30);

        Debug.Log("���� ������ ���� ��");
    }

    async Task SumAsync(int a, int b)
    {
        // Task.Delay�� ����Ͽ� ���� �ɸ��� �۾��� �񵿱������� ����
        await Task.Delay(3000); // 3�� ����
        int num3 = a + b;
        Debug.Log("���� �ɸ��� �۾� �Ϸ�");
        Debug.Log($"�񵿱� �۾� ���: {num3}");
    }

    async Task<int> SumAsyncR(int a, int b)
    {
        await Task.Delay(3000);
        Debug.Log("���� �ɸ��� �۾� �Ϸ�");
        return a + b;
    }
}

public class AsyncAwaitTest4_2 : MonoBehaviour
{
    EventHandler eventHandler;

    private void Start()
    {
        Debug.Log("���� ������ ����");

        eventHandler += VoidAsync;
        eventHandler.Invoke(this, EventArgs.Empty);
    }

    async void VoidAsync(object sender, EventArgs e)
    {
        int result = await SumAsync(10, 20);
        Debug.Log($"�񵿱� �۾� ��� : {result}");
    }

    private async Task<int> SumAsync(int v1, int v2)
    {
        await Task.Delay(3000); // 3�� ���
        Debug.Log("���� �ɸ��� �۾� �Ϸ�");
        return v1 + v2;
    }
}
