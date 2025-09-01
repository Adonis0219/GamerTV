using UnityEngine;

namespace Adapter
{
    public class NpcToPlayer : PlayerBase
    {
        [SerializeField] NpcA _npcA;
        
        public override void Idle()
        {
            Debug.Log("Npc Idle");
        }

        public override void Attack()
        {
            Debug.Log("Npc Sell 기능으로 Attack 대체");
            _npcA.Sell();
        }

        public override void Move()
        {
            Debug.Log("Npc Move");
        }

        public override void MoveToTarget()
        {
            Debug.Log("Npc Buy 기능으로 MoveToTarget 대체");
            _npcA.Buy();
        }
    }
}