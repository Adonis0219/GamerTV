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
            
            // �Ÿ��� ����
            List<Enemy> enemies = EnemyManager1.Instance.FindNearestEnemy(enemyList, playerPos);

            // ����� �� 5���� ����
            List<Enemy> tempList = new List<Enemy>();
            tempList.Add(enemies[0]);
            tempList.Add(enemies[1]);
            tempList.Add(enemies[2]);
            tempList.Add(enemies[3]);
            tempList.Add(enemies[4]);

            // Hp�� ���� ���� �� ����
            tempList = EnemyManager1.Instance.FindLowHpTarget(tempList);

            if (tempList[0] as Enemy) { /* ��ų ó�� */ }
            
            #endregion

            #region 2
            
            EnemyIterator enemyIterator = new EnemyIterator(enemyList);

            while (enemyIterator.MoveNext())
            {
                // �ݺ� ���� ����
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
