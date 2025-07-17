using System;
using UnityEngine;

// 제네릭으로 넘겨줄 수 있기에 상속 제거
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
    // 제네릭 이벤트 핸들러
    public event EventHandler<EventTest1> eventHandler;

    private void Start()
    {
        EventTest1 eventTest = new EventTest1("이벤트 테스트"); // 이벤트에 전달할 정보 생성

        eventHandler += Test; // 이벤트 핸들러 등록

        eventHandler.Invoke(this, eventTest); // 이벤트 호출
    }

    /// <summary>
    /// 이벤트 핸들러 메소드
    /// </summary>
    /// <param name="o">이벤트를 실행시키는 객체 (보통 this)</param>
    /// <param name="e">이벤트 실행 시, 전달하고 싶은 정보가 있을 때 사용</param>
    void Test(object o, EventTest1 e)
    {
        Debug.Log("Test");
        Debug.Log(e._name);
    }
}
