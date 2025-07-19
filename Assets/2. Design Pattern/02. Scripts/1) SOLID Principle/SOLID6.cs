using UnityEngine;

namespace SOLID
{
    public class  Character2 : MonoBehaviour
    {
        public void Move() { Debug.Log("Move"); }
        public void Idle() { Debug.Log("Idle"); }
    }

    // Character와 Player6는 Liskov Substitution Principle을 따르고 있음
    public class Player7 : Character2, IAttack
    {
        private IAttack attackType;
        public IAttack AttackType { set { attackType = value; } }

        private void Start()
        {
            Attack();
            Move();
            base.Idle();
        }

        public void Attack() { attackType.Attack(); }
    }

    public class Monster : Character2, IAttack
    {
        private IAttack attackType;
        public IAttack AttackType { set { attackType = value; } }

        private void Start()
        {
            Attack();
            Move();
            Idle();
        }

        public void Attack() { attackType.Attack(); }
    }

    // Character와 NPC는 Liskov Substitution Principle을 따르고 있음
    public class NPC2 : Character2
    {
        private void Start()
        {
            Move();
            Idle();
        }
    }
}

public interface IAttack
{
    public void Attack();
}