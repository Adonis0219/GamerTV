using UnityEngine;

public class TypeCasting : MonoBehaviour
{
    // 형변환
    // () 소괄호 자료형으로 변환 -> 명시적 형변환
    void Start()
    {
        
    }

    void IntCasting()
    {
        sbyte a = 127;
        Debug.Log(a);   // 127

        int b = (int)a;
        Debug.Log(b);   // 127

        int c = 128;
        Debug.Log(c);   // 128;

        sbyte d = (sbyte)c;
        Debug.Log(d);   // -128;
        
        // 오버플로우
        // 데이터 형식의 최대값보다 큰 값을 넣을 경우 데이터를 다 넣지 못하고 넘치는 현상
    }

    void IntCasting2()
    {
        int a = 200;
        Debug.Log(a);   // 200

        uint b = (uint)a;
        Debug.Log(b);   // 200

        int c = -30;
        Debug.Log(c);   // -30

        uint d = (uint)c;
        Debug.Log(d);   // 4294967266 -> 표현할 수 없는 숫자를 넣었으므로 쓰레기값이 나옴
        
        // 언더플로우
        // 데이터 형식의 최소값보다 작은 값을 넣을 경우 흘러 넘치는 현상 (넣지 못하는 현상)
    }

    void FloatCasting()
    {
        float a = 69.6875f;
        Debug.Log($"a : {a}");  // 69.6875
        
        double b = (double)a;
        Debug.Log($"b : {b}");  // 69.6875

        float c = 0.1f;
        Debug.Log($"c : {c}");  // .1

        double d = (double)c;
        Debug.Log($"d : {d}");  // 0.100000001490116
        
        // 실수형 형변환은 과정이 복잡해 예기치 못한 오류가 발생할 수 있다
    }

    void IntFloatCasting()
    {
        float a = .9f;
        int b = (int)a;
        Debug.Log(b);   // 0 -> 내림 적용
        
        float c = 1.1f;
        int d = (int)c;
        Debug.Log(d);   // 1 -> 내림 적용
    }

    void StringNumCasting()
    {
        int a = int.Parse("12345");
        Debug.Log($"a : {a}");
        float b = float.Parse("123.45");
        Debug.Log($"b : {b}");

        int c = 1234;
        string d = c.ToString();
        Debug.Log($"d : {d}");

        float e = 123.45f;
        string f = e.ToString();
        Debug.Log($"f : {f}");
        
        // 자료형.Parse("내용") : 내용을 자료형으로 변환
        // .ToString() : . 앞의 변수를 string으로 변환
    }
}
