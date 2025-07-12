using System;
using UnityEngine;

public class Interface : MonoBehaviour
{
    // �������̽�
    // Ŭ������ �ƴϱ� ������ ���� ��� ����
    // �ν��Ͻ� ��ü ���� �Ұ�
    public interface IAttack
    {
        public void Attack();
    }
    
    public interface IMove
    {
        public void Move();
    }

    public class Orc : IAttack, IMove
    {
        public void Attack()
        {
            Debug.Log("Orc Attack");
        }

        public void Move()
        {
            Debug.Log("Move");
        }
    }
}
