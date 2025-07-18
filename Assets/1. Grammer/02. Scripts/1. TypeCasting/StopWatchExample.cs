using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class StopWatchExample : MonoBehaviour
{
    private Stopwatch watch = new Stopwatch();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num1 = 0;
        
        // 스탑워치 실행
        watch.Start();

        // 숫자 사이 언더바(_) -> 가독성을 위해 사용 가능
        for (int i = 0; i < 10_000_000; i++)
        {
            num1 += 1;
        }
        
        // 스탑워차 정지
        watch.Stop();

        // ElapsedMilliseconds : 스탑워치의 시간 흐름 간극을 ms로 반환
        Debug.Log($"int : {watch.ElapsedMilliseconds} ms");
        
        ///////////////////////////////////////////////
        // 스탑워치 초기화
        watch.Reset();

        float num2 = 0f;
        
        watch.Start();

        for (int i = 0; i < 10_000_000; i++)
        {
            num2 += 1.0f;
        }
        
        watch.Stop();
        
        Debug.Log($"float : {watch.ElapsedMilliseconds} ms");
    }
}
