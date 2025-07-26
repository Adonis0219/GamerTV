using UnityEngine;

namespace SOLID
{
    interface IAttak
    {
        void Attack();
    }

    interface IMove
    {
        void Move();
    }

interface IIdle
    {
        void Idle();
    }


    public class Player8 : IAttak, IMove, IIdle
    {
        public void Attack(){ Debug.Log("Player is attacking."); }
        public void Move(){ Debug.Log("Player is moving."); }
        public void Idle(){ Debug.Log("Player is Idle."); }
    }

    public class NPC4 : IMove, IIdle
    {
        public void Attack(){ } // NPC는 공격하지 않음
        public void Move(){ Debug.Log("NPC is moving."); }
        public void Idle(){ Debug.Log("NPC is Idle."); }
    }
}