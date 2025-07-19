using UnityEngine;

namespace SOLID
{
    interface ICharacter
    {
        void Move();
        void Attack();
        void Idle();
    }

    public class Player_7 : ICharacter
    {
        public void Attack(){ Debug.Log("Player is attacking."); }
        public void Move(){ Debug.Log("Player is moving."); }
        public void Idle(){ Debug.Log("Player is Idle."); }
    }

    public class NPC3 : ICharacter
    {
        public void Attack(){ } // NPC는 공격하지 않음
        public void Move(){ Debug.Log("NPC is moving."); }
        public void Idle(){ Debug.Log("NPC is Idle."); }
    }
}