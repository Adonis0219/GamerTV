using System;
using UnityEngine;

namespace StateTest
{
    public class Player2 : MonoBehaviour
    {
        public bool _isAttack;

        [SerializeField] private Animator _animator;
        [SerializeField] private Enemy _enemy;

        private State _preState;
        private State _tempState;
        private State _curState;

        public void Start() { }

        public void SetState(State state)
        {
            _tempState = _curState;
            _curState = state;
            _preState = _tempState;
        }

        public void Action()
        {
            if (_preState != null)
                _preState.OnStateExit();
            
            _curState.
                OnStateEnter();
        }

        void EnemyDamage() => _enemy.OnDamaged();
    }
    
    public class Enemy : MonoBehaviour
    {
        public void OnDamaged() { }
    }
}

