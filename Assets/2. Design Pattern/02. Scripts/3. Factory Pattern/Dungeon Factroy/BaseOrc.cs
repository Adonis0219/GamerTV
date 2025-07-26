using UnityEngine;

public abstract class BaseOrc : Dungeon.BaseMonster
{
    // 오크만 가지는 스텟
    public int def;

    protected BaseOrc(int _hp, int _atk, int _def)
    {
        hp = _hp;
        atk = _atk;
        def = _def;
    }

    public override void Attack(int atk)
    {
        Debug.Log($"오크 공격 데미지 : {atk}");
    }

    // 오크만 가지는 도발 스킬
    public abstract void Aggression(int def);
}
