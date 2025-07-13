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
        
        void Buff1() { Debug.Log("Buff1"); }    // 버프식 계산 함수 1
        void Buff2() { Debug.Log("Buff2"); }     // 버프식 계산 함수 2
        void NoneBuff() {}  // 버프 없을 때
    }

    private void Start()
    {
        Player player = new Player();
        player._buff = Player.Buff.Buff1;
        player.Attack(player._buff);
    }
}
