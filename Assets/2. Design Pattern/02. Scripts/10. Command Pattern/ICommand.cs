using UnityEngine;

namespace Command
{
    public interface ICommand
    {
        void Execute(); // 실행
        void Undo();    // 실행 취소
    }
}