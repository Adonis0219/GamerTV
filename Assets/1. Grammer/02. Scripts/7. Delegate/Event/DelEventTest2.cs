using System;
using UnityEngine;

public class EventTest : EventArgs
{
    public string _name;

    public EventTest(string name)
    {
        _name = name;
    }
}

public class DelEventTest2 : MonoBehaviour
{
    // �̺�Ʈ �ڵ鷯
    public event EventHandler eventHandler;

    private void Start()
    {
        EventTest eventTest = new EventTest("�̺�Ʈ �׽�Ʈ"); // �̺�Ʈ�� ������ ���� ����

        eventHandler += Test; // �̺�Ʈ �ڵ鷯 ���

        eventHandler.Invoke(this, eventTest); // �̺�Ʈ ȣ��
    }

    /// <summary>
    /// �̺�Ʈ �ڵ鷯 �޼ҵ�
    /// </summary>
    /// <param name="o">�̺�Ʈ�� �����Ű�� ��ü (���� this)</param>
    /// <param name="e">�̺�Ʈ ���� ��, �����ϰ� ���� ������ ���� �� ���</param>
    void Test(object o, EventArgs e)
    {
        Debug.Log("Test");
        Debug.Log(((EventTest)e)._name);
    }
}
