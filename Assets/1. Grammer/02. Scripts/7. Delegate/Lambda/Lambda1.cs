using UnityEngine;

// ���ٽ� C# 3.0

// �͸� �޼ҵ�(Anonymous Method) C# 2.0���� ���Ե� ���
// ��������Ʈ�� ���޵Ǵ� �޼ҵ尡 ��ȸ������ �ʿ��� �� ����մϴ�.
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
