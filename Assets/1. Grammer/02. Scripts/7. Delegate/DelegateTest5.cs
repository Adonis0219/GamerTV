using System;
using UnityEngine;

public class DelegateTest5 : MonoBehaviour
{
    class Player
    {
        public enum Buff { None, Buff1, Buff2 };

        public Buff _buff;
        
        public void BuffCheck(Buff buff)
        {
            switch (buff)
            {
                case Buff.None:
                    NoneBuff();
                    break;
                case Buff.Buff1:
                    Buff1();
                    break;
                case Buff.Buff2:
                    Buff2();
                    break;
            }
        }

        public void Attack(Buff buff)
        {
            BuffCheck(buff);
            Debug.Log("Attack!");
        }
        
        void Buff1() { Debug.Log("Buff1"); }    // ������ ��� �Լ� 1
        void Buff2() { Debug.Log("Buff2"); }     // ������ ��� �Լ� 2
        void NoneBuff() {}  // ���� ���� ��
    }

    private void Start()
    {
        Player player = new Player();
        player._buff = Player.Buff.Buff1;
        player.Attack(player._buff);
    }
}
