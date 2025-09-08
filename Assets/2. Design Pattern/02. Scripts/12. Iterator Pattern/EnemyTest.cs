using System.Collections.Generic;
using UnityEngine;

namespace iterator
{
    public class EnemyTest : MonoBehaviour
    {
        public Vector3 playerPos;
        
        void Start()
        {
            List<Enemy> enemyList = EnemyManager1.Instance._enemies;
            
            #region 1
            
            // 거리순 정렬
            List<Enemy> enemies = EnemyManager1.Instance.FindNearestEnemy(enemyList, playerPos);

            // 가까운 적 5마리 선정
            List<Enemy> tempList = new List<Enemy>();
            tempList.Add(enemies[0]);
            tempList.Add(enemies[1]);
            tempList.Add(enemies[2]);
            tempList.Add(enemies[3]);
            tempList.Add(enemies[4]);

            // Hp가 가장 낮은 적 선정
            tempList = EnemyManager1.Instance.FindLowHpTarget(tempList);

            if (tempList[0] as Enemy) { /* 스킬 처리 */ }
            
            #endregion

            #region 2
            
            EnemyIterator enemyIterator = new EnemyIterator(enemyList);

            while (enemyIterator.MoveNext())
            {
                // 반복 내용 실행
               Enemy enemy = enemyIterator.Current as Enemy;
               enemy.OnDamaged();
            }

            #endregion

            #region 3

            DistanceSortIterator distanceSortIterator
                = new DistanceSortIterator(new EnemyIterator(enemyList), playerPos);

            LowHpSortIterator lowHpSortIterator
                = new LowHpSortIterator(distanceSortIterator, 1);

            if (lowHpSortIterator.Current is Enemy temp)
            {
                Enemy target = temp;
            }

            #endregion

            #region 4

            EnemyIterator iterator = new EnemyIterator(enemyList);

            Enemy selectEnemy 
                = enemyIterator.DistanceFilter(playerPos, 5.0f)
                               .LowHpSort(1)
                               .Current as Enemy;

            #endregion
        }
    }
}
