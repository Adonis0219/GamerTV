using System.Collections.Generic;
using UnityEngine;

namespace iterator
{
    public class EnemyManager : MonoBehaviour
    {
        public List<Enemy> _enemies = new List<Enemy>();

        // 거리가 가까운 순서로 정렬 후 가장 가까운 타겟 반환
        public Enemy FindNearestEnemy(Vector3 playerPos)
        {
            if (_enemies == null || _enemies.Count == 0)
            {
                Debug.Log("주변에 적이 없습니다.");
            }
            
            _enemies.Sort((a, b) =>
            {
                float distA = Vector3.Distance(playerPos, a.transform.position);
                float distB = Vector3.Distance(playerPos, b.transform.position);

                return distA.CompareTo(distB);
            });

            return _enemies[0];
        }

        // hp가 적은 순서로 타깃을 정렬
        // 정렬된 리스트 반환
        public List<Enemy> FindLowHpTarget()
        {
            _enemies.Sort((a, b) =>
            {
                int hpA = a.curHp;
                int hpB = b.curHp;

                return hpA.CompareTo(hpB);
            });

            return _enemies;
        }
    }

    public class Enemy : MonoBehaviour
    {
        public int curHp;
        
        public void OnDamaged(){}
    }
    
}