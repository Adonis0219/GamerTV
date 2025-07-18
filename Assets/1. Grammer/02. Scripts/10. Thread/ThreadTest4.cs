using System.Threading;
using UnityEngine;

public class ThreadTest4 : MonoBehaviour
{
    public class Param
    {
        public int value1;
        public float value2;
    }

    Thread thread;

    void Start()
    {
        thread = new Thread(Temp);
        Param param = new Param();
        param.value1 = 10;
        param.value2 = 20.5f;
        thread.Start(param); // �Ű������� ��ü�� �����Ͽ� ������ ����
    }

    void Temp(object num)
    {
        Debug.Log("������ ����");
        Debug.Log(thread.ThreadState);
        Thread.Sleep(2000); // 2�� ��� -> ������ ����
        Param param = (Param)num; // object Ÿ���� Param Ÿ������ ��ȯ
        Debug.Log(param.value1); // ù��° �Ű����� ���
        Debug.Log(param.value2); // �ι�° �Ű����� ���
        Debug.Log("������ ����");
    }
}