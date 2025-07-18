using System;
using UnityEngine;

namespace DI
{
    public class Player3 : MonoBehaviour
    {
        IAttackType _attackType;

        public void SetAttackType(IAttackType type)
        {
            _attackType = type;
        }

        public void Attack()
        {
            _attackType.Attack();
        }
    }
}