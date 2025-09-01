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
            Debug.Log("Npc Sell ������� Attack ��ü");
            _npcA.Sell();
        }

        public override void Move()
        {
            Debug.Log("Npc Move");
        }

        public override void MoveToTarget()
        {
            Debug.Log("Npc Buy ������� MoveToTarget ��ü");
            _npcA.Buy();
        }
    }
}