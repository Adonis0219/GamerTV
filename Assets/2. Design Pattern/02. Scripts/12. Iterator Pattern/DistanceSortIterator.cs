using System.Collections.Generic;
using UnityEngine;

namespace iterator
{
    public class DistanceSortIterator : Iterator
    {
        private List<Enemy> _enemies = new List<Enemy>();
        private int _index = -1;

        public DistanceSortIterator(Iterator iterator, Vector3 playerPos)
        {
            while (iterator.MoveNext())
            {
                if (iterator.Current is Enemy enemy)
                {
                    _enemies.Add(enemy);
                }
            }

            SortDistance(playerPos);
        }

        void SortDistance(Vector3 playerPos)
        {
            _enemies.Sort((a, b) =>
            {
                float distA = Vector3.Distance(playerPos, a.transform.position);
                float distB = Vector3.Distance(playerPos, b.transform.position);

                return distA.CompareTo(distB);
            });
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