using UnityEngine;

public class S_Orc : BaseOrc
{
    public S_Orc(int _hp, int _atk, int _def) : base(_hp, _atk, _def)
    {
        // 자식에서 따로 할 게 없어 비움
    }

    public override void Attack(int atk)
    {
        Debug.Log("S급 오크의 공격");
        base.Attack(atk);
    }

    public override void Aggression(int def)
    {
        Debug.Log($"S급 오크 도발 {def}만큼 데미지 감소");
    }
}
