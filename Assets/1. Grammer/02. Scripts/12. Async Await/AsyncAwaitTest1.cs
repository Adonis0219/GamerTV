using UnityEngine;

public class AsyncAwaitTest1 : MonoBehaviour
{
    // ����
    // ����(Synchronous) ���� : �ڵ尡 ���������� ����Ǹ�, ���� �۾��� �Ϸ�� ������ ���� �۾��� ����մϴ�.

    // �񵿱�
    // �񵿱�(Asynchronous) ���� : �ڵ尡 ���ķ� ����Ǹ�, ���� �۾��� �Ϸ���� �ʾƵ� ���� �۾��� ������ �� �ֽ��ϴ�.

    // async / await
    // C# 5.0���� ����

    void Start()
    {
        Test1();
        Test2();
        Test3();
    }

    void Test1() { Debug.Log("Test1"); }
    void Test2() { Debug.Log("Test2"); }
    void Test3() { Debug.Log("Test3"); }
}
