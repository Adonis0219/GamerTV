using System;
using UnityEngine;

public class DelegateTest8 : MonoBehaviour
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
        /* + 연산자
        // + 연산자 활용 예시
        testDel = new TestDelegate(Chain1)
                  + new TestDelegate(Chain2)
                  + new TestDelegate(Chain3);*/
        
        testDel = Chain1;
        testDel += Chain2;
        testDel += Chain3;
        
        testDel();
    }
}
