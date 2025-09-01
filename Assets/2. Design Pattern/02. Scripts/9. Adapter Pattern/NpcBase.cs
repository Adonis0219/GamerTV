using UnityEngine;

namespace Adapter
{
    public abstract class NpcBase : MonoBehaviour
    {
        public abstract void Sell();
        public abstract void Buy();
    }
}