using UnityEngine;

public class DelegateTest4 : MonoBehaviour
{
    public delegate void TestDelegate(); // ��������Ʈ Ÿ�� ����

    TestDelegate _testDel; // ��ü ����

    void Start()
    {
        TestDelegate result = Do();
        
        result.Invoke();
    }
    
    TestDelegate Do()
    {
        return _testDel = TargetF;  // �Լ� ����
    }
    
    void TargetF()
    {
        // ���� �ִ� �ڵ带 ����ϰ� �ʹ�
        Debug.Log("TargetF");
    }
}
