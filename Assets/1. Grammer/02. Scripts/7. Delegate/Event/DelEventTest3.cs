using System;
using UnityEngine;

// ���׸����� �Ѱ��� �� �ֱ⿡ ��� ����
public class  EventTest1
{
    public string _name;

    public EventTest1(string name)
    {
        _name = name;
    }
}

public class DelEventTest3 : MonoBehaviour
{
    // ���׸� �̺�Ʈ �ڵ鷯
    public event EventHandler<EventTest1> eventHandler;

    private void Start()
    {
        EventTest1 eventTest = new EventTest1("�̺�Ʈ �׽�Ʈ"); // �̺�Ʈ�� ������ ���� ����

        eventHandler += Test; // �̺�Ʈ �ڵ鷯 ���

        eventHandler.Invoke(this, eventTest); // �̺�Ʈ ȣ��
    }

    /// <summary>
    /// �̺�Ʈ �ڵ鷯 �޼ҵ�
    /// </summary>
    /// <param name="o">�̺�Ʈ�� �����Ű�� ��ü (���� this)</param>
    /// <param name="e">�̺�Ʈ ���� ��, �����ϰ� ���� ������ ���� �� ���</param>
    void Test(object o, EventTest1 e)
    {
        Debug.Log("Test");
        Debug.Log(e._name);
    }
}
