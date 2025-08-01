using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
public class FindComponentsAttribute : Attribute
{
    public string[] _gameObjectNames { get; }

    public FindComponentsAttribute(params string[] gameObjectNames)
    {
        _gameObjectNames = gameObjectNames;
    }
}

public class AttributeTest4 : MonoBehaviour
{
    [FindComponents("Target1")] public Rigidbody rb;
    [FindComponents("Target1")] public BoxCollider bc;
    [FindComponents("Target2")] public AudioSource aSource;
    [FindComponents("Target3", "Target4")] public AudioSource[] audioArr = new AudioSource[2];

    private void Awake()
    {
        // FindComponent Attribute만 부착한다고 해당 컴포넌트를 초기화 해주는 것이 아니기에
        // 주입 함수 실행
        Utils.InjectComponents(this);
    }
}
