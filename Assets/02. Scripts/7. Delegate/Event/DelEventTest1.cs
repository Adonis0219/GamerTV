      using System;
using UnityEngine;

// 델리게이트 이벤트 (Delegate Event)
// 객체의 상태 변화나 사건의 발생을 알리는 용도

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
