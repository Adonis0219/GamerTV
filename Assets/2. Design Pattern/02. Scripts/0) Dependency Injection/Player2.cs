using System;
using UnityEngine;

namespace DI
{
    public class Player2 : MonoBehaviour
    {
        public enum AttackType
        {
            BaseAttack, SpecialAttack
        }

        AttackType attackType;

        void Start()
        {

        }

        public void Attack()
        {
            if (attackType == AttackType.BaseAttack)
            {
                BaseAttack();
            }
            else if (attackType == AttackType.SpecialAttack)
            {
                SpecialAttack();
            }
        }

        public void BaseAttack() { Debug.Log("Base Attack!"); }
        public void SpecialAttack() { Debug.Log("Special Attack!"); }
    }
}