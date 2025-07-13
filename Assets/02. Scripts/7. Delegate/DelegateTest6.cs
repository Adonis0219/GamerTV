using System;
using UnityEngine;

public class DelegateTest6 : MonoBehaviour
{
    class Player
    {
        delegate void BuffDelegate();   // Ÿ�� ����

        private BuffDelegate _buffDel;  // ��ü(����) ����
        
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
                        // �Լ��� ���� �����ϰ�
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
        
        // ���ุ �ϰ� _Buff ������Ƽ�� ���������� ��������� �ʴ�
        public void Attack()
        {
            // ���߿� ȣ���Ѵ�
            _buffDel.Invoke();
            Debug.Log("Attack");
        }

        void Buff1() { Debug.Log("Buff1"); }    // ������ ��� �Լ� 1
        void Buff2() { Debug.Log("Buff2"); }     // ������ ��� �Լ� 2
        void NoneBuff() {}  // ���� ���� ��
    }
    
    private void Start()
    {
        Player player = new Player();
        player._Buff = Player.Buff.Buff1;
        player.Attack();
    }
}
