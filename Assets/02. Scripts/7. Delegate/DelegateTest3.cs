using UnityEngine;

public class DelegateTest3 : MonoBehaviour
{
    public delegate void TestDelegate(); // 델리게이트 타입 선언

    TestDelegate _testDel; // 객체 정의
    
    public void Start()
    {
        _testDel = TargetF; // 함수 참조
        Do(_testDel);
    }

    void Do(TestDelegate del)
    {
        del();
    }
    
    void TargetF()
    {
        // 여기 있는 코드를 사용하고 싶다
        Debug.Log("TargetF");
    }
}
