      using System;
using UnityEngine;

// ��������Ʈ �̺�Ʈ (Delegate Event)
// ��ü�� ���� ��ȭ�� ����� �߻��� �˸��� �뵵

public class TestDele
{
    public delegate void TestEvent();

    public event TestEvent testEvent;

    public void StartEvent()
    {
        testEvent.Invoke();
    }
}
 
public class DelEventTest1 : MonoBehaviour
{
    private void Start()
    {
        TestDele testDele = new TestDele();
        testDele.testEvent += Test1;
        testDele.testEvent += Test2;
        testDele.testEvent += Test3;

        //testDele.testEvent = Test1;

        //testDele.testEvent.Invoke();

        testDele.StartEvent();
    }
    
    public void Test1() { Debug.Log("Test1");}
    public void Test2() { Debug.Log("Test2");}
    public void Test3() { Debug.Log("Test3");}
}
