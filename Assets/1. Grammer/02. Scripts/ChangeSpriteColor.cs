using System;
using UnityEngine;

public class ChangeSpriteColor : MonoBehaviour
{
    private SpriteRenderer target;

    private void Awake()
    {
        target = GetComponent<SpriteRenderer>();
    }
    
    // 이벤트 메소드 등록용
    public void Call(Color color)
    {
        target.color = color;
    }
}
