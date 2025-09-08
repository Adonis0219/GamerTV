using System.Collections.Generic;
using UnityEngine;

namespace iterator
{
    public class EnemyManager : MonoBehaviour
    {
        public List<Enemy> _enemies = new List<Enemy>();

        // �Ÿ��� ����� ������ ���� �� ���� ����� Ÿ�� ��ȯ
        public Enemy FindNearestEnemy(Vector3 playerPos)
        {
            if (_enemies == null || _enemies.Count == 0)
            {
                Debug.Log("�ֺ��� ���� �����ϴ�.");
            }
            
            _enemies.Sort((a, b) =>
            {
                float distA = Vector3.Distance(playerPos, a.transform.position);
                float distB = Vector3.Distance(playerPos, b.transform.position);

                return distA.CompareTo(distB);
            });

            return _enemies[0];
        }

        // hp�� ���� ������ Ÿ���� ����
        // ���ĵ� ����Ʈ ��ȯ
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