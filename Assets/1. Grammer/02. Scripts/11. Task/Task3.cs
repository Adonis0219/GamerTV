using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    void Start()
    {
        Task task = new Task(() => Thread.Sleep(3000));

        task.Start();
        task.Wait();    // Task가 완료될 때까지 현재 스레드 대기

        Debug.Log("Task 실행 완료");
    }
}
