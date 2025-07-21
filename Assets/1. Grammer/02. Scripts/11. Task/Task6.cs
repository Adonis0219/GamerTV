using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Task6 : MonoBehaviour
{
    void Start()
    {
        Task task = Task.Factory.StartNew(() => Thread.Sleep(3000));

        task.Wait();
        Debug.Log("¿Ï·á");
    }
}
