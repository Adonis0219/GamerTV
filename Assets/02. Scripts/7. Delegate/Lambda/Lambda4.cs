using UnityEngine;

public class Lambda4 : MonoBehaviour
{
    delegate int TestDelegate(int a, int b);

    void Start()
    {
        TestDelegate test;
        test = delegate(int a, int b)
        {
            return a + b; // ���ٽ��� ��ȯ���� �־�� �մϴ�.
        };

        int sum = test.Invoke(3, 5);
        Debug.Log("Sum: " + sum); // Sum : 8
    }
}
