using System.Xml.Serialization;
using UnityEngine;

namespace Dungeon
{
    public abstract class BaseMonster : MonoBehaviour
    {
        // 몬스터라면 가지는 스텟
        public int hp;
        public int atk;

        public abstract void Attack(int atk);
    }
}