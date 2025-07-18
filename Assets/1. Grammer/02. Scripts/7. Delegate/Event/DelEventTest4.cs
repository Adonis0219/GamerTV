using System;
using UnityEngine;
using UnityEngine.UI;

public class EventTest2 : EventArgs
{
    private EventHandler eventHandler;

    public event EventHandler EventHandler
    {
        add
        {
            Debug.Log("Event added");
            eventHandler += value;
        }
        remove
        {
            Debug.Log("Event removed");
            eventHandler -= value;
        }
    }

    public void StartEvent()
    {
        Debug.Log("Event started");
        eventHandler?.Invoke(this, EventArgs.Empty);
    }
}

public class DelEventTest4 : MonoBehaviour
{
    private void Start()
    {
        EventTest2 eventTest = new EventTest2();

        eventTest.EventHandler += Test;
        eventTest.StartEvent();
    }

    void Test(object o, EventArgs e)
    {
        Debug.Log("Test");
    }
}
