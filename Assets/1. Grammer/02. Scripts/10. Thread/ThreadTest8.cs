using System.Threading;
using UnityEngine;

public class ThreadTest8 : MonoBehaviour
{
    // ������ Ǯ


    // ������ ���� ���
    // 1) ��� ���� : �����尡 �����Ǹ� ���� ���� �ð����� ������ �ִ� ���, ���� ������ ����
    // 2) ��ȸ�� �ӽ� ���� : Ư�� ������ �����ϰ� ����Ǵ� ���, ª�� �ð����� �����

    // ������ Ǯ ��� ����
    // ������ Ǯ�� �����带 �̸� ������ ����, �ʿ��� ������ �����ϴ� �������,
    // ������ ������ ���ῡ ��� ����� �ٿ� ������ ����ŵ�ϴ�.
    void Start()
    {
        // ���ο� ������ ������ ����

        ThreadPool.QueueUserWorkItem(TestThreadPool);

        // Thread.Start() �޼ҵ尡 ����

        Thread thread = new Thread(Test);
    }

    void TestThreadPool(object value)
    {
        Debug.Log("������Ǯ ����");
    }

    void Test()
    {
        while (true)
        {

        }
    }
}
