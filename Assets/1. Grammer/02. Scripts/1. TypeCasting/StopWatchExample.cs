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
        
        // ��ž��ġ ����
        watch.Start();

        // ���� ���� �����(_) -> �������� ���� ��� ����
        for (int i = 0; i < 10_000_000; i++)
        {
            num1 += 1;
        }
        
        // ��ž���� ����
        watch.Stop();

        // ElapsedMilliseconds : ��ž��ġ�� �ð� �帧 ������ ms�� ��ȯ
        Debug.Log($"int : {watch.ElapsedMilliseconds} ms");
        
        ///////////////////////////////////////////////
        // ��ž��ġ �ʱ�ȭ
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
