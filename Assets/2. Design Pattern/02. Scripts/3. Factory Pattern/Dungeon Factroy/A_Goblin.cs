using UnityEngine;

public class A_Goblin : BaseGoblin
{
    public A_Goblin(int _hp, int _atk, int _def) : base(_hp, _atk, _def)
    {
        // �ڽĿ��� ���� �� �� ���� ���
    }

    public override void Attack(int atk)
    {
        Debug.Log("A�� ����� ����");
        base.Attack(atk);
    }

    public override void Dodge(int dex)
    {
        Debug.Log($"{dex}�� Ȯ���� ȸ��");
    }
}
