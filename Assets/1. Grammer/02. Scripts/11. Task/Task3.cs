using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    void Start()
    {
        Task task = new Task(() => Thread.Sleep(3000));

        task.Start();
        task.Wait();    // Task�� �Ϸ�� ������ ���� ������ ���

        Debug.Log("Task ���� �Ϸ�");
    }
}
