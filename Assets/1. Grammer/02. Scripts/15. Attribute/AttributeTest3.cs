using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
public class FindComponentAttribute : Attribute
{
    public string _gameObjectName { get; }

    public FindComponentAttribute(string gameObjectName)
    {
        _gameObjectName = gameObjectName;
    }
}

public class AttributeTest3 : MonoBehaviour
{
    [FindComponent("Target1")] public Rigidbody rb;
    [FindComponent("Target1")] public BoxCollider bc;
    [FindComponent("Target2")] public AudioSource aSource;

    private void Awake()
    {
        // FindComponent Attribute만 부착한다고 해당 컴포넌트를 초기화 해주는 것이 아니기에
        // 주입 함수 실행
        Utils.InjectComponents2(this);
    }
}
