using System.Collections.Generic;
using UnityEngine;

namespace iterator
{
    public class SkillTest : MonoBehaviour
    {
        public void SelectEnemy(List<Enemy> enemyList, Vector3 playerPos)
        {
            EnemyIterator iterator1 = new EnemyIterator(enemyList);

            Iterator enemyIterator = iterator1.DistanceFilter(playerPos, 5.0f).LowHpSort(1);

            while (enemyIterator.MoveNext())
            {
                Enemy enemy = enemyIterator.Current as Enemy;
                enemy.OnDamaged();
            }
        }
    }
    
    public class SkillTest2 : MonoBehaviour
    {
        public void SelectEnemy(List<Enemy> enemyList, Vector3 playerPos)
        {
            EnemyIterator iterator1 = new EnemyIterator(enemyList);

            Iterator enemyIterator = iterator1.DistanceFilter(playerPos, 5.0f).LowHpSort(1);

            while (enemyIterator.MoveNext())
            {
                Enemy enemy = enemyIterator.Current as Enemy;
                enemy.OnDamaged();
            }
        }
    }
}
