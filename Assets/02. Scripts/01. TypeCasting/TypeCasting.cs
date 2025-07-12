using UnityEngine;

public class TypeCasting : MonoBehaviour
{
    // ����ȯ
    // () �Ұ�ȣ �ڷ������� ��ȯ -> ����� ����ȯ
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
        
        // �����÷ο�
        // ������ ������ �ִ밪���� ū ���� ���� ��� �����͸� �� ���� ���ϰ� ��ġ�� ����
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
        Debug.Log(d);   // 4294967266 -> ǥ���� �� ���� ���ڸ� �־����Ƿ� �����Ⱚ�� ����
        
        // ����÷ο�
        // ������ ������ �ּҰ����� ���� ���� ���� ��� �귯 ��ġ�� ���� (���� ���ϴ� ����)
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
        
        // �Ǽ��� ����ȯ�� ������ ������ ����ġ ���� ������ �߻��� �� �ִ�
    }

    void IntFloatCasting()
    {
        float a = .9f;
        int b = (int)a;
        Debug.Log(b);   // 0 -> ���� ����
        
        float c = 1.1f;
        int d = (int)c;
        Debug.Log(d);   // 1 -> ���� ����
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
        
        // �ڷ���.Parse("����") : ������ �ڷ������� ��ȯ
        // .ToString() : . ���� ������ string���� ��ȯ
    }
}
