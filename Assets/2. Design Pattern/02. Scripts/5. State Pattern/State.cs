using UnityEngine;

namespace StateTest
{
    public abstract class State : MonoBehaviour
    {
        // 상태 진입 시 한 번 호출
        public abstract void OnStateEnter(); 
        // 상태 중 매 프레임 호출
        public abstract void OnStateUpdate();   
        // 상태 끝나기 전 마지막 한 번 호출
        public abstract void OnStateExit();     
    }
}


