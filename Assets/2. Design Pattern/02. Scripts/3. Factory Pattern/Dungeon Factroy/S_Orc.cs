using UnityEngine;

public class S_Orc : BaseOrc
{
    public S_Orc(int _hp, int _atk, int _def) : base(_hp, _atk, _def)
    {
        // �ڽĿ��� ���� �� �� ���� ���
    }

    public override void Attack(int atk)
    {
        Debug.Log("S�� ��ũ�� ����");
        base.Attack(atk);
    }

    public override void Aggression(int def)
    {
        Debug.Log($"S�� ��ũ ���� {def}��ŭ ������ ����");
    }
}
