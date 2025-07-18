using System;
using UnityEngine;

public class DelegateTest7 : MonoBehaviour
{
    // 델리게이트 체인 (Delegate Chain)
    // 여러 함수를 동시에 참조할 수 있다.
    
    delegate void TestDelegate();   // 델리게이트 타입 정의

    private TestDelegate testDel;   // 델리게이트 변수 선언
    
    // 참조할 함수들
    void Chain1() { Debug.Log("Chain1");}
    void Chain2() { Debug.Log("Chain2");}
    void Chain3() { Debug.Log("Chain3");}

    private void Start()
    {
        TestDelegate test1 = new TestDelegate(Chain1);
        TestDelegate test2 = new TestDelegate(Chain2);
        TestDelegate test3 = new TestDelegate(Chain3);

        // Combine(a, b) 델리게이트 a, b를 묶어주는 함수
        // as 형변환 -> 형변환이 가능하다면 형변환 불가능하다면 null 반환
        testDel = Delegate.Combine(test1, test2) as TestDelegate;
        testDel = Delegate.Combine(testDel, test3) as TestDelegate;

        testDel();
    }
}
