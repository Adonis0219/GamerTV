using UnityEngine;

public class Lambda4_1 : MonoBehaviour
{
    delegate int TestDelegate(int a, int b);

    void Start()
    {
        TestDelegate test;
        // �Ʒ��� �� ���� ǥ�� ����� ������ ��, ���� ���ۿ��� ���� X
        // Ÿ�� �߷� ����
        test = (a, b) => a + b;
        // Ÿ�� �߷��� ����� ��(object�� ���ٸ� �����ϰų�, var ��� ��)
        test = (int a, int b) => a + b;

        test = (a, b) =>
        {
            Debug.Log("Calculating sum...");
            return a + b;
        };

        int sum = test.Invoke(3, 5);
        Debug.Log("Sum: " + sum); // Sum : 8
    }
}
