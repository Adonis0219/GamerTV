using System.Xml.Serialization;
using UnityEngine;

namespace Dungeon
{
    public abstract class BaseMonster : MonoBehaviour
    {
        // ���Ͷ�� ������ ����
        public int hp;
        public int atk;

        public abstract void Attack(int atk);
    }
}