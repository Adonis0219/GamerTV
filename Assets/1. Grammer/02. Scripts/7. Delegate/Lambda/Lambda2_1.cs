using UnityEngine;

public class Lambda2_1 : MonoBehaviour
{
    delegate void TestDelegate();

    void Start()
    {
        TestDelegate test;
        test = () => Debug.Log("Hello Lambda!");

        test.Invoke();
    }
}
