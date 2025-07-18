using UnityEngine;

public class Lambda4_1 : MonoBehaviour
{
    delegate int TestDelegate(int a, int b);

    void Start()
    {
        TestDelegate test;
        // 아래의 두 식은 표현 방식의 차이일 뿐, 실제 동작에는 차이 X
        // 타입 추론 가능
        test = (a, b) => a + b;
        // 타입 추론이 어려울 때(object에 람다를 대입하거나, var 사용 시)
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
