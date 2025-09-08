using System.Collections.Generic;
using UnityEngine;

namespace iterator
{
    public class SkillTypeA : Iterable
    {
        private List<Enemy> enemyList = new List<Enemy>();
        private Vector3 playerPos;

        public SkillTypeA(List<Enemy> enemyList, Vector3 playerPos)
        {
            this.enemyList = enemyList;
            this.playerPos = playerPos;
        }
        
        public Iterator GetIterator()
        {
            EnemyIterator iterator1 = new EnemyIterator(enemyList);

            return iterator1.DistanceFilter(playerPos, 5.0f).LowHpSort(1);
        }
    }
}