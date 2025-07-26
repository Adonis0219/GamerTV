using System;
using UnityEngine;

namespace DI
{
    public class Player1 : MonoBehaviour
    {
        void Start()
        {

        }

        public void Attack()
        {
            // Attack 메서드는 BaseAttack 메서드에 의존하고 있다
            BaseAttack();
        }

        public void BaseAttack() { Debug.Log("Base Attack!"); }
    }
}