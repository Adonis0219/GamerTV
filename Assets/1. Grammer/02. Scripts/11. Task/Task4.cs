using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task4 : MonoBehaviour
{
    void Start()
    {
        Task task = new Task(() => Thread.Sleep(3000));

        task.ContinueWith((obj) => Debug.Log("Task �Ϸ�"));

        task.Start();

        Debug.Log("Task ���� �Ϸ�");
    }
}
