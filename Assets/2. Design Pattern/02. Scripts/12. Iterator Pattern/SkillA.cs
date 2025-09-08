using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace iterator
{
    public class SkillA : MonoBehaviour
    {
        private Iterable SkillTypeA;
        private Enemy enemy;

        // 스킬 사용 시
        public void OnSkill(List<Enemy> enemies, Vector3 playerPos)
        {
            SkillTypeA = new SkillTypeA(enemies, playerPos);
            SelectEnemy();
            StartCoroutine(CoOnSkill());
        }
        
        // 타겟 선정
        void SelectEnemy()
        {
            // GetIterator 메서드를 통해 선정된 리스트를 가져올 수 있다
            Iterator iterator = SkillTypeA.GetIterator();

            while (iterator.MoveNext())
            {
                enemy = iterator.Current as Enemy;

                // 대미지 계산
                if (enemy != null) enemy.OnDamaged();
            }
        }

        IEnumerator CoOnSkill()
        {
            // 스킬 로직
            yield return null;
        }
    }
}