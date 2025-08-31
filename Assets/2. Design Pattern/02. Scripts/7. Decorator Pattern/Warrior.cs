using System;
using Deco1;
using UnityEngine;

namespace Deco1
{
    public class Warrior : DecoComponent
    {
        public int _Hp;
        public int _Atk;
        public int _Def;

        private void Awake()
        {
            _Hp = 10;
            _Atk = 5;
            _Def = 5;
        }
        
        public override void Operation()
        {
            Debug.Log($"{this.GetType().Name} State : Hp {_Hp}, Atk {_Atk}, Def {_Def}");
            Debug.Log("==============================");
        }
    }
}