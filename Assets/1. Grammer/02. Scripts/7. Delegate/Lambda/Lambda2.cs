using UnityEngine;

public class Lambda2 : MonoBehaviour
{
    delegate void TestDelegate();

    void Start()
    {
        TestDelegate test;
        test = delegate()
        {
           Debug.Log("TestFunction");
        };

        test.Invoke();
    }
}
