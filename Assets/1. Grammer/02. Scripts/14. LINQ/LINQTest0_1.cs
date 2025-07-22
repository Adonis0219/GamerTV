using UnityEngine;

public class LINQTest0_1 : MonoBehaviour
{
    void Start()
    {
        int i = 5;
        var j = 10;

        Debug.Log(i.GetType().FullName);    // System.Int32
        Debug.Log(j.GetType().FullName);    // System.Int32
    }
}
