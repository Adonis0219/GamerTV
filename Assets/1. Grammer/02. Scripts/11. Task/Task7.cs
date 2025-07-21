using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task7 : MonoBehaviour
{
    void Start()
    {
        Task<int> task1 = new Task<int>(() => 1);
        Task<float> task2 = Task.Run(() => 2.0f);
        Task<long> task3 = Task.Factory.StartNew(()=> 3L);

        task1.Start();

        task1.Wait();
        task2.Wait();
        task3.Wait();

        Debug.Log(task1.Result);
        Debug.Log(task2.Result);
        Debug.Log(task3.Result);
    }
}
