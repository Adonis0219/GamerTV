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
        // FindComponent Attribute�� �����Ѵٰ� �ش� ������Ʈ�� �ʱ�ȭ ���ִ� ���� �ƴϱ⿡
        // ���� �Լ� ����
        Utils.InjectComponents2(this);
    }
}
