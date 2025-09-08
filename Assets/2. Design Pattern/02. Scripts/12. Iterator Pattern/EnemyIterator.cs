using System.Collections.Generic;

namespace iterator
{
    public class EnemyIterator : Iterator
    {
        private List<Enemy> _enemies;
        private int _index = -1;

        public EnemyIterator(List<Enemy> enemies)
        {
            _enemies = enemies;
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