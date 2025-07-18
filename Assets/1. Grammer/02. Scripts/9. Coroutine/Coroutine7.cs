using System.Collections;
using UnityEngine;

public class Coroutine7 : MonoBehaviour
{
    int count = 0;

    void Start()
    {
        StartCoroutine(WaitLoop());
    }

    private void Update()
    {
        if (count < 1000)
        {
            count++;
        }

        Debug.Log("Count: " + count);
    }

    IEnumerator WaitLoop()
    {
        yield return new WaitUntil(() => count == 1000);

        Debug.Log("1000 reached!");
    }
}
