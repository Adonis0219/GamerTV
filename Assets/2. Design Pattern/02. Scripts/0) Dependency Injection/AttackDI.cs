using UnityEngine;

namespace DI
{
    public class AttackDI : MonoBehaviour
    {
        public BaseAttack baseAtk;
        public SpecialAttack specialAtk;
        public MagicAttack magicAtk;

        public Player3 player;

        private void Start()
        {
            player.SetAttackType(baseAtk);
            player.Attack();
        }
    }
}