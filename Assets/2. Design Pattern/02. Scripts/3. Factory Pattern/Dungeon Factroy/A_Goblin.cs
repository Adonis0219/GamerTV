using UnityEngine;

public class A_Goblin : BaseGoblin
{
    public A_Goblin(int _hp, int _atk, int _def) : base(_hp, _atk, _def)
    {
        // 자식에서 따로 할 게 없어 비움
    }

    public override void Attack(int atk)
    {
        Debug.Log("A급 고블린의 공격");
        base.Attack(atk);
    }

    public override void Dodge(int dex)
    {
        Debug.Log($"{dex}의 확률로 회피");
    }
}
