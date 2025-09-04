using UnityEngine;
using UnityEngine.Timeline;

namespace Command
{
    public class MoveCommand : ICommand
    {
        private Player player;
        private Vector2Int dir;
        private Vector2Int prePos;

        public MoveCommand(Player player, Vector2Int dir)
        {
            this.player = player;
            this.dir = dir;
        }
        
        public void Execute()
        {
            prePos = player.Position;
            player.Move(dir);
        }

        public void Undo()
        {
            player.Move(prePos - player.Position);  // 반대 방향으로 이동
        }
    }
}