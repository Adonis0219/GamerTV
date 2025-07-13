using System;
using UnityEngine;

public class DelegateTest6 : MonoBehaviour
{
    class Player
    {
        delegate void BuffDelegate();   // 타입 정의

        private BuffDelegate _buffDel;  // 객체(변수) 선언
        
        public enum Buff { None, Buff1, Buff2 };

        private Buff _buff;

        public Buff _Buff
        {
            get => _buff;
            set
            {
                if (_buff == value) return;

                _buff = value;
                
                switch (_buff)
                {
                    case Buff.None:
                        // 함수를 먼저 참조하고
                        _buffDel = NoneBuff;
                        break;
                    case Buff.Buff1:
                        _buffDel = Buff1;
                        break;
                    case Buff.Buff2:
                        _buffDel = Buff2;
                        break;
                }

                // _buffDel = _buff switch
                // {
                //     Buff.None => NoneBuff,
                //     Buff.Buff1 => Buff1,
                //     Buff.Buff2 => Buff2,
                //     _ => _buffDel
                // };
            }
        }
        
        // 실행만 하고 _Buff 프로퍼티와 직접적으로 연결돼있진 않다
        public void Attack()
        {
            // 나중에 호출한다
            _buffDel.Invoke();
            Debug.Log("Attack");
        }

        void Buff1() { Debug.Log("Buff1"); }    // 버프식 계산 함수 1
        void Buff2() { Debug.Log("Buff2"); }     // 버프식 계산 함수 2
        void NoneBuff() {}  // 버프 없을 때
    }
    
    private void Start()
    {
        Player player = new Player();
        player._Buff = Player.Buff.Buff1;
        player.Attack();
    }
}
