using UnityEngine;

namespace Adapter
{
    public class InputSystem : MonoBehaviour
    {
        [SerializeField] PlayerBase _playerBase;

        public void Idle()
        {
            _playerBase.Idle();
        }
        public void Attack()
        {
            _playerBase.Attack();
        }
        public void Move()
        {
            _playerBase.Move();
        }
        public void MoveToTarget()
        {
            _playerBase.MoveToTarget();
        }
    }
}