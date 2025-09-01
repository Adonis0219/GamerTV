using UnityEngine;

namespace Adapter
{
    public abstract class PlayerBase : MonoBehaviour
    {
        public abstract void Idle();
        public abstract void Attack();
        public abstract void Move();
        public abstract void MoveToTarget();
    }
}