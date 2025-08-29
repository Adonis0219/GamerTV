using UnityEngine;

namespace StateTest
{
    public abstract class State : MonoBehaviour
    {
        // ���� ���� �� �� �� ȣ��
        public abstract void OnStateEnter(); 
        // ���� �� �� ������ ȣ��
        public abstract void OnStateUpdate();   
        // ���� ������ �� ������ �� �� ȣ��
        public abstract void OnStateExit();     
    }
}


