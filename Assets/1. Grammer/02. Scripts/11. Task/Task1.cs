using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task1 : MonoBehaviour
{
    void Start()
    {
        Task task = new Task(BackGroundTask);
        task.Start();
    }

    private void BackGroundTask()
    {
        bool isBackground = Thread.CurrentThread.IsBackground;
        Debug.Log($"��׶��� ������ : {isBackground}");

        bool isThreadPoolThread = Thread.CurrentThread.IsThreadPoolThread;
        Debug.Log($"������ Ǯ ������ : {isThreadPoolThread}");
    }
}
