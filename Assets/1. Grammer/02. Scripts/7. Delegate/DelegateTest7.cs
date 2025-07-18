using System;
using UnityEngine;

public class DelegateTest7 : MonoBehaviour
{
    // ��������Ʈ ü�� (Delegate Chain)
    // ���� �Լ��� ���ÿ� ������ �� �ִ�.
    
    delegate void TestDelegate();   // ��������Ʈ Ÿ�� ����

    private TestDelegate testDel;   // ��������Ʈ ���� ����
    
    // ������ �Լ���
    void Chain1() { Debug.Log("Chain1");}
    void Chain2() { Debug.Log("Chain2");}
    void Chain3() { Debug.Log("Chain3");}

    private void Start()
    {
        TestDelegate test1 = new TestDelegate(Chain1);
        TestDelegate test2 = new TestDelegate(Chain2);
        TestDelegate test3 = new TestDelegate(Chain3);

        // Combine(a, b) ��������Ʈ a, b�� �����ִ� �Լ�
        // as ����ȯ -> ����ȯ�� �����ϴٸ� ����ȯ �Ұ����ϴٸ� null ��ȯ
        testDel = Delegate.Combine(test1, test2) as TestDelegate;
        testDel = Delegate.Combine(testDel, test3) as TestDelegate;

        testDel();
    }
}
