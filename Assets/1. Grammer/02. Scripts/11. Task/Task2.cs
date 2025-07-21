using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    void Start()
    {
        ThreadPool.QueueUserWorkItem((obj) =>
        {
            Debug.Log("스레드 풀 스레드 시작");
        });

        Task task = new Task(() => Debug.Log("Task 실행"));

        task.Start();
        task.Wait();
    }
}
