using System.Collections.Generic;
using UnityEngine;

namespace iterator
{
    public class EnemyManager1 : Singleton<EnemyManager1>
    {
        public List<Enemy> _enemies = new List<Enemy>();

        // 거리가 가까운 순서로 정렬 후 가장 가까운 타겟 반환
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

        // hp가 적은 순서로 타깃을 정렬
        // 정렬된 리스트 반환
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