using UnityEngine;

namespace SOLID
{
    // SRP(Single Responsibility Principle) 위반 예시
    public class  Player2
    {
        public void Attack()
        {
            Debug.Log("Player1 attacks!");
        }

        public void Move()
        {
            Debug.Log("Player1 moves!");
        }

        public void Idle()
        {
            Debug.Log("Player1 is idle!");
        }
    }

    public class  LoadGameData
    {
        public void LoadAllGameData()
        {
            // 모든 게임 데이터 로드
        }
    }
}

