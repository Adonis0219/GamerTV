using System;
using UnityEngine;

public class Interface : MonoBehaviour
{
    // 인터페이스
    // 클래스가 아니기 떄문에 다중 상속 가능
    // 인스턴스 객체 생성 불가
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
