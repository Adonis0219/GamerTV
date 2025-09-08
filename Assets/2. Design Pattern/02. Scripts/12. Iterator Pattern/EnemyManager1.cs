using System.Collections.Generic;
using UnityEngine;

namespace iterator
{
    public class EnemyManager1 : Singleton<EnemyManager1>
    {
        public List<Enemy> _enemies = new List<Enemy>();

        // �Ÿ��� ����� ������ ���� �� ���� ����� Ÿ�� ��ȯ
        public List<Enemy> FindNearestEnemy(List<Enemy> enemies, Vector3 playerPos)
        {
            enemies.Sort((a, b) =>
            {
                float distA = Vector3.Distance(playerPos, a.transform.position);
                float distB = Vector3.Distance(playerPos, b.transform.position);

                return distA.CompareTo(distB);
            });

            return enemies;
        }

        // hp�� ���� ������ Ÿ���� ����
        // ���ĵ� ����Ʈ ��ȯ
        public List<Enemy> FindLowHpTarget(List<Enemy> enemies)
        {
            enemies.Sort((a, b) =>
            {
                int hpA = a.curHp;
                int hpB = b.curHp;

                return hpA.CompareTo(hpB);
            });

            return enemies;
        }
    }
}