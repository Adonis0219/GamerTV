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
            // Attack �޼���� BaseAttack �޼��忡 �����ϰ� �ִ�
            BaseAttack();
        }

        public void BaseAttack() { Debug.Log("Base Attack!"); }
    }
}