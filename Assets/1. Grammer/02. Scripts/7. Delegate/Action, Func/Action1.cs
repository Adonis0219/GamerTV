using System;
using UnityEngine;

public class Action1 : MonoBehaviour
{
    Action action;

    void Start()
    {
        action = () => Debug.Log("Action1");
        action += () => Debug.Log("Action2");
        action += () => Debug.Log("Action3");

        action?.Invoke();
    }

    public void Test(int num)
    {
        Debug.Log(num);
    }
}
