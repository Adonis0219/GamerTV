using UnityEngine;

namespace Template
{
    public abstract class PlayerBase : MonoBehaviour
    {
        public virtual void Idle()
        {
            // ���� Idle ����
        }

        public virtual void Move()
        {
            // ���� Move ����
        }

        public abstract void MoveTarget();
        public abstract void Attack();
    }
}