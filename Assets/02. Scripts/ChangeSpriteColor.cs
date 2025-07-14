using System;
using UnityEngine;

public class ChangeSpriteColor : MonoBehaviour
{
    private SpriteRenderer target;

    private void Awake()
    {
        target = GetComponent<SpriteRenderer>();
    }
    
    // �̺�Ʈ �޼ҵ� ��Ͽ�
    public void Call(Color color)
    {
        target.color = color;
    }
}
