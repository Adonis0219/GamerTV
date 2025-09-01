using UnityEngine;

namespace Template
{
    public abstract class PlayerBase : MonoBehaviour
    {
        public virtual void Idle()
        {
            // 공용 Idle 구현
        }

        public virtual void Move()
        {
            // 공용 Move 구현
        }

        public abstract void MoveTarget();
        public abstract void Attack();
    }
}