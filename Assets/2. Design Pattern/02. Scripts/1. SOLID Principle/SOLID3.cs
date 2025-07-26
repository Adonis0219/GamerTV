using UnityEngine;

namespace SOLID
{
    // SRP(Single Responsibility Principle) ���� ����
    // Ŭ������ �ʹ� �� ��� Ex) 1000�� ¥��
    public class  Player3
    {
        public void Attack()
        {
            // 300��
            Debug.Log("Player1 attacks!");
        }

        public void Move()
        {
            // 300��
            Debug.Log("Player1 moves!");
        }

        public void Idle()
        {
            // 300��
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
            // 300��
            Debug.Log("Player1 attacks!");
        }
    }

    public class Player4Move
    {
        public void Move()
        {
            // 300��
            Debug.Log("Player1 moves!");
        }
    }

    public class Player4Idle
    {
        public void Idle()
        {
            // 300��
            Debug.Log("Player1 is idle!");
        }
    }
}

