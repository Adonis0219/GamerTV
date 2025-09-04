using System;
using UnityEngine;
using UnityEngine.UI;

namespace Command
{
    public class GameManager : MonoBehaviour
    {
        private CommandManager commandMgr;

        private Player player;
        // 4가지 방향 넣기
        private Vector2Int[] directions = new Vector2Int[4];

        private Button upBt, downBt, leftBt, rightBt;

        private void Start()
        {
            upBt.onClick.AddListener(() => ExecuteMove(0));
            downBt.onClick.AddListener(() => ExecuteMove(1));
            leftBt.onClick.AddListener(() => ExecuteMove(2));
            rightBt.onClick.AddListener(() => ExecuteMove(3));
        }

        void ExecuteMove(int dirIndex)
        {
            ICommand moveCommand = new MoveCommand(player, directions[dirIndex]);
            commandMgr.ExecuteCommand(moveCommand);
            commandMgr.RecordCommand(moveCommand);  // 되돌리기를 위한 커맨드 기록
        }
    }
}