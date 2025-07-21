using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task5 : MonoBehaviour
{
    Task task1, task2, task3;
    Stopwatch stopWatch;

    void Start()
    {
        stopWatch = new Stopwatch();
        stopWatch.Start();

        task1 = Task.Run(Task1Function);
        task2 = Task.Run(() =>
        {
            Thread.Sleep(1000);
        });

        task3 = Task.WhenAll(task1, task2);
    }

    private void Update()
    {
        if (task3.IsCompleted)
        {
            stopWatch.Stop();
            UnityEngine.Debug.Log("��� �۾��� �Ϸ�Ǿ����ϴ�.");
            UnityEngine.Debug.Log($"��� �ð� : {stopWatch.Elapsed.TotalSeconds.ToString("F2")} s");
        }
    }

    private void Task1Function()
    {
        Thread.Sleep(3000);
    }
}
