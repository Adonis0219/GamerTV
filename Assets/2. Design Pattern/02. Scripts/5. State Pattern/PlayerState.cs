using System.Collections;
using UnityEngine;

namespace StateTest
{
    public class PlayerIdle : State
    {
        [SerializeField] private Player2 player;
        [SerializeField] private Animator anim;
        
        public override void OnStateEnter()
        {
            anim.SetInteger("State", 1);
        }

        public override void OnStateUpdate() {}

        public override void OnStateExit() {}
    }

    public class PlayerMove : State
    {
        [SerializeField] private Player2 player;
        [SerializeField] private Animator anim;
        [SerializeField] private Transform playerTransform;

        private float speed = 5;
        private Coroutine coru;
        
        public override void OnStateEnter()
        {
            anim.SetInteger("State", 2);
            OnStateUpdate();
        }

        public override void OnStateUpdate()
        {
            if (coru == null)
                coru = StartCoroutine(CoOnStateUpdate());
        }

        IEnumerator CoOnStateUpdate()
        {
            while (true)
            {
                // 이동 로직

                yield return null;
            }
        }

        public override void OnStateExit()
        {
            StopCoroutine(coru);
            coru = null;
        }
    }
}


