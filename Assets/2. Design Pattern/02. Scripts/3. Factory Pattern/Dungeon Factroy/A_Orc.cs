using UnityEngine;

public class A_Orc : BaseOrc
{
    public A_Orc(int _hp, int _atk, int _def) : base(_hp, _atk, _def)
    {
        // �ڽĿ��� ���� �� �� ���� ���
    }

    public override void Attack(int atk)
    {
        Debug.Log("A�� ��ũ�� ����");
        base.Attack(atk);
    }

    public override void Aggression(int def)
    {
        Debug.Log($"A�� ��ũ ���� {def}��ŭ ������ ����");
    }
}
