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
            Debug.Log("������ Ǯ ������ ����");
        });

        Task task = new Task(() => Debug.Log("Task ����"));

        task.Start();
        task.Wait();
    }
}
