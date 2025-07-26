using UnityEngine;

namespace Dungeon
{
    public abstract class DungeonFactory : MonoBehaviour
    {
        public abstract BaseOrc CreateOrc();
        public abstract BaseGoblin CreateGoblin();
    }
}