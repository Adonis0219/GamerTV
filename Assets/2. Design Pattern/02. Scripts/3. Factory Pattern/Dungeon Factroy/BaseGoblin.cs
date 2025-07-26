using UnityEngine;

public abstract class BaseGoblin : Dungeon.BaseMonster
{
    // ����� ������ ����
    public int dex;

    protected BaseGoblin(int _hp, int _atk, int _dex)
    {
        hp = _hp;
        atk = _atk;
        dex = _dex;
    }

    public override void Attack(int atk)
    {
        Debug.Log($"��� ���� ������ : {atk}");
    }

    // ����� ������ ȸ�� ��ų
    public abstract void Dodge(int dex);
}
