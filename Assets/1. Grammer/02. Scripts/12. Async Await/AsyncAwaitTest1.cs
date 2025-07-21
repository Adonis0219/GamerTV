using UnityEngine;

public class AsyncAwaitTest1 : MonoBehaviour
{
    // 동기
    // 동기(Synchronous) 실행 : 코드가 순차적으로 실행되며, 이전 작업이 완료될 때까지 다음 작업이 대기합니다.

    // 비동기
    // 비동기(Asynchronous) 실행 : 코드가 병렬로 실행되며, 이전 작업이 완료되지 않아도 다음 작업을 시작할 수 있습니다.

    // async / await
    // C# 5.0부터 지원

    void Start()
    {
        Test1();
        Test2();
        Test3();
    }

    void Test1() { Debug.Log("Test1"); }
    void Test2() { Debug.Log("Test2"); }
    void Test3() { Debug.Log("Test3"); }
}
