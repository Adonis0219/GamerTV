using UnityEngine;

// 람다식 C# 3.0

// 익명 메소드(Anonymous Method) C# 2.0부터 도입된 기능
// 델리게이트에 전달되는 메소드가 일회성으로 필요할 때 사용합니다.
public class Lambda1 : MonoBehaviour
{
    delegate void TestDelegate();

    void Start()
    {
        TestDelegate test;
        test = TestFunction;

        test.Invoke();
    }
    
    void TestFunction()
    {
        Debug.Log("TestFunction");
    }
}
