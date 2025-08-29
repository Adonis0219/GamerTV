using System;
using UnityEngine;

namespace StateTest
{
    public enum PlayerState
    {
        None, Idle, Move, Attack
    }
    
    public class Player : MonoBehaviour
    {
        public PlayerState state { get; set; }

        [SerializeField] private Animator anim;

        private void Start()
        {
            state = PlayerState.Idle;
        }

        private void Update()
        {
            UpdateAnimation();
        }

        void UpdateAnimation()
        {
            switch (state)
            {
                case PlayerState.None: // None 局聪
                    break;
                case PlayerState.Idle: // Idle 局聪
                    break;
                case PlayerState.Move: // Move 局聪
                    break;
                case PlayerState.Attack: // Attack 局聪
                    break;
            }
        }
    }
}