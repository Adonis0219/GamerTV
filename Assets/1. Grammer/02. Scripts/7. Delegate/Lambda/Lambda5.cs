using UnityEngine;

public class Lambda5 : MonoBehaviour
{
    delegate void TestDelegate();

    private void Start()
    {
        TestDelegate test;

        test = TestFunction1;
        test += TestFunction2;
        test -= TestFunction1;

        test.Invoke();
    }

    void TestFunction1() { Debug.Log("TestFunction1 called"); }
    void TestFunction2() { Debug.Log("TestFunction2 called"); }
}
