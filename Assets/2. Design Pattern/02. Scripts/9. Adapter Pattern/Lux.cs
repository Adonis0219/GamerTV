using UnityEngine;

namespace Adapter
{
    public class Lux : PlayerBase
    {
        public override void Idle()
        {
            Debug.Log("Lux Idle");
        }

        public override void Attack()
        {
            Debug.Log("Lux Attack");
        }

        public override void Move()
        {
            Debug.Log("Lux Move");
        }

        public override void MoveToTarget()
        {
            Debug.Log("Lux MoveToTarget");
        }
    }
}

