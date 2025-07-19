using UnityEngine;

namespace SOLID
{
    public class  Character : MonoBehaviour
    {
        public void Attack() { Debug.Log("Attack"); }
        public void Move() { Debug.Log("Move"); }
        public void Idle() { Debug.Log("Idle"); }
    }

    // Character와 Player6는 Liskov Substitution Principle을 따르고 있음
    // Player6는 Character의 모든 기능을 사용
    // Player6는 Character를 대체 가능
    public class Player6 : Character
    {
        private void Start()
        {
            Attack();
            Move();
            Idle();
        }
    }

    // Character와 NPC는 Liskov Substitution Principle을 따르지 않음
    // NPC는 Character의 Attack 기능을 사용하지 않음
    // NPC는 Character를 대체할 수 없음
    public class NPC : Character
    {
        private void Start()
        {
            Attack();   // 공격하지 않는 NPC는 필요 없는 기능
            Move();
            Idle();
        }
    }
}