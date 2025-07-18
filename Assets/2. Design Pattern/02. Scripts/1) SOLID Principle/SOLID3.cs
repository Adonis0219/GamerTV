using UnityEngine;

namespace SOLID
{
    // SRP(Single Responsibility Principle) 위반 예시
    // 클래스가 너무 길 경우 Ex) 1000줄 짜리
    public class  Player3
    {
        public void Attack()
        {
            // 300줄
            Debug.Log("Player1 attacks!");
        }

        public void Move()
        {
            // 300줄
            Debug.Log("Player1 moves!");
        }

        public void Idle()
        {
            // 300줄
            Debug.Log("Player1 is idle!");
        }
    }

    public class Player4
    {
        Player4Attack p4Atk;
        Player4Move p4Move;
        Player4Idle p4Idle;

        public void Attack() { p4Atk.Attack(); }
        public void Move() { p4Move.Move(); }
        public void Idle() { p4Idle.Idle(); }
    }

    public class  Player4Attack
    {
        public void Attack()
        {
            // 300줄
            Debug.Log("Player1 attacks!");
        }
    }

    public class Player4Move
    {
        public void Move()
        {
            // 300줄
            Debug.Log("Player1 moves!");
        }
    }

    public class Player4Idle
    {
        public void Idle()
        {
            // 300줄
            Debug.Log("Player1 is idle!");
        }
    }
}

