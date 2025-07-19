using UnityEngine;

namespace SOLID
{
    public class  Character : MonoBehaviour
    {
        public void Attack() { Debug.Log("Attack"); }
        public void Move() { Debug.Log("Move"); }
        public void Idle() { Debug.Log("Idle"); }
    }

    // Character�� Player6�� Liskov Substitution Principle�� ������ ����
    // Player6�� Character�� ��� ����� ���
    // Player6�� Character�� ��ü ����
    public class Player6 : Character
    {
        private void Start()
        {
            Attack();
            Move();
            Idle();
        }
    }

    // Character�� NPC�� Liskov Substitution Principle�� ������ ����
    // NPC�� Character�� Attack ����� ������� ����
    // NPC�� Character�� ��ü�� �� ����
    public class NPC : Character
    {
        private void Start()
        {
            Attack();   // �������� �ʴ� NPC�� �ʿ� ���� ���
            Move();
            Idle();
        }
    }
}