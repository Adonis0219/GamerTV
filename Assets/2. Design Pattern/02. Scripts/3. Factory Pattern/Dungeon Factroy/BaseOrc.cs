using UnityEngine;

public abstract class BaseOrc : Dungeon.BaseMonster
{
    // ��ũ�� ������ ����
    public int def;

    protected BaseOrc(int _hp, int _atk, int _def)
    {
        hp = _hp;
        atk = _atk;
        def = _def;
    }

    public override void Attack(int atk)
    {
        Debug.Log($"��ũ ���� ������ : {atk}");
    }

    // ��ũ�� ������ ���� ��ų
    public abstract void Aggression(int def);
}
