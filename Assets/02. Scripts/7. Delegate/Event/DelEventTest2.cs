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
    // 이벤트 핸들러
    public event EventHandler eventHandler;

    private void Start()
    {
        EventTest eventTest = new EventTest("이벤트 테스트"); // 이벤트에 전달할 정보 생성

        eventHandler += Test; // 이벤트 핸들러 등록

        eventHandler.Invoke(this, eventTest); // 이벤트 호출
    }

    /// <summary>
    /// 이벤트 핸들러 메소드
    /// </summary>
    /// <param name="o">이벤트를 실행시키는 객체 (보통 this)</param>
    /// <param name="e">이벤트 실행 시, 전달하고 싶은 정보가 있을 때 사용</param>
    void Test(object o, EventArgs e)
    {
        Debug.Log("Test");
        Debug.Log(((EventTest)e)._name);
    }
}
