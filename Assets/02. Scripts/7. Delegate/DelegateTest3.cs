using UnityEngine;

public class DelegateTest3 : MonoBehaviour
{
    public delegate void TestDelegate(); // ��������Ʈ Ÿ�� ����

    TestDelegate _testDel; // ��ü ����
    
    public void Start()
    {
        _testDel = TargetF; // �Լ� ����
        Do(_testDel);
    }

    void Do(TestDelegate del)
    {
        del();
    }
    
    void TargetF()
    {
        // ���� �ִ� �ڵ带 ����ϰ� �ʹ�
        Debug.Log("TargetF");
    }
}
