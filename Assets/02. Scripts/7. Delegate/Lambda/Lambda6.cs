using UnityEngine;

public class Lambda6 : MonoBehaviour
{
    delegate void TestDelegate();

    private void Start()
    {
        TestDelegate test;

        test = () => Debug.Log("TestFunction1 called");
        test += () => Debug.Log("TestFunction2 called");
        test -= () => Debug.Log("TestFunction2 called");

        test.Invoke();
    }
}
