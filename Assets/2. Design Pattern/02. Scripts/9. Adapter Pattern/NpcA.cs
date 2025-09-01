using UnityEngine;

namespace Adapter
{
    public class NpcA : NpcBase
    {
        public override void Sell()
        {
            Debug.Log("Sell");
        }

        public override void Buy()
        {
            Debug.Log("Buy");
        }
    }
}