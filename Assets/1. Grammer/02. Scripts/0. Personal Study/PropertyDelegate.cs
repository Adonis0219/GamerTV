using System;
using UnityEngine;

public class PropertyDelegate : MonoBehaviour
{
    int curHp;

    event Action dieAction;

    public int CurHp
    {
        get
        {
            return curHp;
        }
        set
        {
            curHp = value;

            if (curHp < 0)
                dieAction?.Invoke();
        }
    }

    void OnEnable()
    {
        dieAction += Die;
    }

    void Die()
    {
        // 죽었을 때 실행할 함수
    }

    private void OnTriggerEnter(Collider other)
    {
        dieAction += ExplosionEffect;
    }

    private void OnTriggerExit(Collider other)
    {
        dieAction -= ExplosionEffect;
    }

    void ExplosionEffect()
    {
        // 터지는 이펙트
    }
}
