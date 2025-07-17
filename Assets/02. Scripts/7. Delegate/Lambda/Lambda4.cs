using UnityEngine;

public class Lambda4 : MonoBehaviour
{
    delegate int TestDelegate(int a, int b);

    void Start()
    {
        TestDelegate test;
        test = delegate(int a, int b)
        {
            return a + b; // 람다식은 반환값이 있어야 합니다.
        };

        int sum = test.Invoke(3, 5);
        Debug.Log("Sum: " + sum); // Sum : 8
    }
}
