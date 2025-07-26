using UnityEngine;

public abstract class BaseGoblin : Dungeon.BaseMonster
{
    // 고블린만 가지는 스텟
    public int dex;

    protected BaseGoblin(int _hp, int _atk, int _dex)
    {
        hp = _hp;
        atk = _atk;
        dex = _dex;
    }

    public override void Attack(int atk)
    {
        Debug.Log($"고블린 공격 데미지 : {atk}");
    }

    // 고블린만 가지는 회피 스킬
    public abstract void Dodge(int dex);
}
