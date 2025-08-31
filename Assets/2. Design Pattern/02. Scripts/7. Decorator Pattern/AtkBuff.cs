using Deco1;
using UnityEngine;

namespace Deco1
{
    public class AtkBuff : Decorator
    {
        [SerializeField] Warrior warrior;
        
        public override void Operation()
        {
            _decoCom.Operation();
            warrior._Atk += 10;
            Debug.Log("���ݷ� 10 ���� ����");
        }
    }
}