using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Command
{
    public class CommandManager : MonoBehaviour
    {
        private Stack<ICommand> commandHistory = new Stack<ICommand>(); // Undo를 위한 스택
        private Queue<ICommand> commandQueue = new Queue<ICommand>();   // 리플레이를 위한 큐

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            commandHistory.Push(command);   // 실행한 커맨드를 기록
        }

        public void RecordCommand(ICommand command)
        {
            commandQueue.Enqueue(command);  // 리플레이를 위한 커맨드 기록
        }

        public void Undo()
        {
            if (commandHistory.Count > 0)
            {
                ICommand command = commandHistory.Pop();
                command.Undo();
            }
        }

        public void Replay() => StartCoroutine(CoReplay());

        IEnumerator CoReplay()
        {
            WaitForSeconds wfs = new WaitForSeconds(0.7f);

            yield return wfs;
            
            while (commandQueue.Count > 0)
            {
                ICommand command = commandQueue.Dequeue();
                command.Execute();
                yield return wfs;
            }
        }
    }
}