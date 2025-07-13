using System;
using UnityEngine;

public class DelegateTest8 : MonoBehaviour
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
        /* + ������
        // + ������ Ȱ�� ����
        testDel = new TestDelegate(Chain1)
                  + new TestDelegate(Chain2)
                  + new TestDelegate(Chain3);*/
        
        testDel = Chain1;
        testDel += Chain2;
        testDel += Chain3;
        
        testDel();
    }
}
