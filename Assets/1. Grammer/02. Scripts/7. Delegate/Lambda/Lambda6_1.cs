using UnityEngine;

public class Lambda6_1 : MonoBehaviour
{
    delegate void TestDelegate();

    private void Start()
    {
        TestDelegate test;

        test = () => Debug.Log("TestFunction1 called");
        test += () => Debug.Log("TestFunction2 called");
        test = null;
        test += () => Debug.Log("TestFunction1 called");

        test.Invoke();
    }
}
