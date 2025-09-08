using System.Collections.Generic;
using UnityEngine;

namespace iterator
{
    public class LowHpSortIterator : Iterator
    {
        private List<Enemy> _enemies = new List<Enemy>();
        private int _index = -1;

        public LowHpSortIterator(Iterator iterator, int enemyCount)
        {
            List<Enemy> enemies = new List<Enemy>();
            
            while (iterator.MoveNext())
            {
                if (iterator.Current is Enemy enemy)
                    _enemies.Add(enemy);
                
            }
            ReturnEnemyCount(SortLowHp(enemies), enemyCount);
        }

        List<Enemy> SortLowHp(List<Enemy> enemies)
        {
            enemies.Sort((a, b) =>
            {
                int hpA = a.curHp;
                int hpB = b.curHp;

                return hpA.CompareTo(hpB);
            });
            return enemies;
        }

        void ReturnEnemyCount(List<Enemy> enemies, int enemyCount)
        {
            for (int i = 0; i < enemyCount; i++)
                _enemies.Add(enemies[i]);
        }
        
        public object Current => _enemies[_index];
        public bool MoveNext()
        {
            _index++;

            return _index < _enemies.Count;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}